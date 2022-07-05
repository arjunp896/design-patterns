using System;

namespace ShamimBurgers1
{
    class HealthyBurgerBuilder : BurgerBuilder
    {
        public override void createNewBurger()
        {
            hamburger = new Hamburger(BurgerType.HEALTHY.ToString(), 
                                          Constants.HEALTHY_ROLL_TYPE, 
                                          Constants.DELUXE_ROLL_TYPE, 
                                          Constants.HEALTHY_BURGER_PRICE);
        }

        public override bool getAdditionsCount()
        {
            if (hamburger.getTotalAdditionAdded() < Constants.HEALTHY_MAX_ADDITIONS)
                return true;
            else
                return false;
        }
    }
}