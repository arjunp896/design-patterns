using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamimBurgers2
{
    class HealthyBuilder : AbstractFactory
    {
        public override Burger createBurger()
        {
            return new HealthyBurgerBuilder();
        }

        public override Pizza createPizza()
        {
            return new HealthyPizzaBuilder();
        }
    }
}
