using System;
using System.Collections.Generic;

namespace ShamimBurgers1
{
    class Waiter
    {
        BurgerBuilder burgerBuilder;

        List<Hamburger> burgers = new List<Hamburger>();

        public void setBurgerBuilder(BurgerBuilder bb)
        {
            burgerBuilder = bb;
            burgerBuilder.createNewBurger();
        }

        public Hamburger getHamburger()
        {
            return burgerBuilder.getHamburger();
        }

        public bool checkForAdditons()
        {
            return burgerBuilder.getAdditionsCount();
        }

        public void addNewAddition(KeyValuePair<string, double> addition)
        {
            burgerBuilder.setNewAddition(addition);
        }

        public void createHamburger()
        {
            burgers.Add(burgerBuilder.getHamburger());
        }

        public List<Hamburger> getFinalOrder()
        {
            return burgers;
        }

        public double getFinalBill()
        {
            double finalAmount = 0;
            foreach (Hamburger hamburger in burgers)
                finalAmount += hamburger.TotalPrice;

            return finalAmount;
        }
    }
}