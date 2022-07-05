using System.Collections.Generic;

namespace ShamimBurgers1
{
    class DeluxeBurgerBuilder : BurgerBuilder
    {
        public override void createNewBurger()
        {
            hamburger = new Hamburger(BurgerType.DELUXE.ToString(),
                                            Constants.DELUXE_ROLL_TYPE,
                                            Constants.DELUXE_MEAT,
                                            Constants.DELUXE_BURGER_PRICE);

            hamburger.addAddition(new KeyValuePair<string, double>("Chips", 2.75));
            hamburger.addAddition(new KeyValuePair<string, double>("Drink", 1.81));
        }

        public override bool getAdditionsCount()
        {
            return false;
        }
    }
}