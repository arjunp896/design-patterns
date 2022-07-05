using System;
using System.Collections.Generic;

namespace ShamimBurgers1
{
    class BurgerBuilder 
    {
        public Hamburger hamburger;

        public Hamburger getHamburger()
        {
            return hamburger;
        }
        public virtual void createNewBurger()
        {
            hamburger = new Hamburger(BurgerType.BASIC.ToString(),
                                      Constants.BASIC_ROLL_TYPE, 
                                      Constants.BASIC_MEAT, 
                                      Constants.BASIC_BURGER_PRICE);
        }

        public virtual bool getAdditionsCount()
        {
            if (hamburger.getTotalAdditionAdded() < Constants.BASIC_MAX_ADDITIONS)
                return true;
            else
                return false;
        }

        public void setNewAddition(KeyValuePair<string, double> addition)
        {
            hamburger.addAddition(addition);
        }
    }
}