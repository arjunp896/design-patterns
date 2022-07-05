using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamimBurgers2
{
    class BasicBuilder : AbstractFactory
    {
        public override Burger createBurger()
        {
            return new BasicBurgerBuilder();
        }

        public override Pizza createPizza()
        {
            return new BasicPizzaBuilder();
        }
    }
}
