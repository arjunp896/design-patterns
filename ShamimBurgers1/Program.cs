using System;
using System.Collections.Generic;

namespace ShamimBurgers1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            string addChoice = "";

            Waiter waiter = new Waiter();
            BurgerBuilder burgerBuilder;

            Console.WriteLine("******************** Welcome to Shamim's Burgers ********************");

            do
            {
                bool validChoiice = true;

                Console.WriteLine("\n\nWe have three types of burgers:");
                Console.WriteLine("\t1 Basic hamburger on a White roll with Sausage");
                Console.WriteLine("\t2 Healthy hamburger  on a Brown rye roll with Bacon");
                Console.WriteLine("\t3 Deluxe hamburger on a White roll with Sausage & Bacon");


                do
                {
                    Console.Write("\nPlease select {0}option from above: ", (validChoiice) ? "" : "valid ");
                    validChoiice = false;
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        choice = 0;
                    }
                }
                while (choice < 1 || choice > 3);

                switch (choice)
                {
                    case 1:
                        burgerBuilder = BurgerFactory.getBurger(BurgerType.BASIC);
                        Console.WriteLine("\nYou can add up to {0} extra additions", Constants.BASIC_MAX_ADDITIONS);
                        break;

                    case 2:
                        burgerBuilder = BurgerFactory.getBurger(BurgerType.HEALTHY);
                        Console.WriteLine("\nYou can add up to {0} extra additions", Constants.HEALTHY_MAX_ADDITIONS);
                        break;

                    case 3:
                        burgerBuilder = BurgerFactory.getBurger(BurgerType.DELUXE);
                        Console.WriteLine("\nYou cannot add extra additions");
                        break;

                    default:
                        burgerBuilder = null;
                        Console.WriteLine("Error");
                        break;
                }

                if (burgerBuilder != null)
                {
                    waiter.setBurgerBuilder(burgerBuilder);

                    addChoice = "";

                    while (waiter.checkForAdditons())
                    {
                        Console.Write("\nDo you want to add any addtionals? (y): ");

                        addChoice = Console.ReadLine();

                        if (addChoice.ToLower() == "y")
                        {
                            Console.WriteLine("\nWe have: ");

                            int i = 1;
                            foreach (KeyValuePair<String, double> addition in Constants.ADDITIONS)
                                Console.WriteLine("\t{0}. {1}, price {2}", i++, addition.Key, addition.Value);

                            Console.WriteLine("\t{0} or press any key To Skip", i);

                            Console.Write("\nPlease Select One from above: ");

                            try
                            {
                                choice = Convert.ToInt32(Console.ReadLine());

                                if (choice < 1 || choice >= i)
                                {
                                    continue;
                                }

                                KeyValuePair<string, double> addition = Constants.ADDITIONS[choice - 1];
                                Console.WriteLine("\n\tAdded {0} for an extra {1}", addition.Key, addition.Value);
                                waiter.addNewAddition(Constants.ADDITIONS[choice - 1]);
                            }
                            catch
                            {
                                continue;
                            }
                        }
                        else
                            break;

                    }

                    waiter.createHamburger();
                }
                do
                {
                    Console.Write("\nDo you want to buy more burger (y/n): ");
                    addChoice = Console.ReadLine();

                }
                while (!(addChoice.ToLower() == "y" || addChoice.ToLower() == "n"));
            }
            while (addChoice.ToLower() == "y");

            List<Hamburger> hamburgers = waiter.getFinalOrder();

            double finalAmount = waiter.getFinalBill();

            foreach (Hamburger hamburger in hamburgers)
            {
                Console.WriteLine("\n\n{0} hamburger on a {1} with {2}, price {3}",
                        hamburger.Name, hamburger.RollType, hamburger.Meat, hamburger.Price);

                if (hamburger.Additions != null)
                    foreach (KeyValuePair<string, double> addition in hamburger.Additions)
                        Console.WriteLine("\tAdded {0} for an extra {1}",
                                addition.Key, addition.Value);

                Console.WriteLine("\nTotal: " + hamburger.TotalPrice);
            }

            Console.WriteLine("\n\nYour final Bill is: " + finalAmount);

            Console.WriteLine("\n\nThank you");

            Console.Read();
        }

    }
}
