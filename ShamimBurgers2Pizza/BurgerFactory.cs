using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamimBurgers2
{
    class BurgerFactory
    {
        public static BurgerBuilder getBurger(BurgerType burgerType)
        {
            BurgerFactory bf = new BurgerFactory();
           
            switch (burgerType)
            {
                case BurgerType.BASIC:

                    return new BurgerBuilder();

                case BurgerType.HEALTHY:

                    return new HealthyBurgerBuilder();

                case BurgerType.DELUXE:

                    return new DeluxeBurgerBuilder();

                default:

                    return null;
            }
        }
    }
}
