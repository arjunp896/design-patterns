using System;
using System.Collections.Generic;

namespace ShamimBurgers2
{
    class Waiter
    {
        BurgerBuilder burgerBuilder;

        List<BasicBurgerBuilder> burgers = new List<BasicBurgerBuilder>();

        public void setBurgerBuilder(BurgerBuilder bb)
        {
            burgerBuilder = bb;
            burgerBuilder.createNewBurger();
        }

        public BasicBurgerBuilder getHamburger()
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

        public List<BasicBurgerBuilder> getFinalOrder()
        {
            return burgers;
        }

        public double getFinalBill()
        {
            double finalAmount = 0;
            foreach (BasicBurgerBuilder hamburger in burgers)
                finalAmount += hamburger.TotalPrice;

            return finalAmount;
        }
    }
}