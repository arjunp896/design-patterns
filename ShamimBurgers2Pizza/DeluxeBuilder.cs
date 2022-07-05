using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamimBurgers2
{
    class DeluxeBuilder : AbstractFactory
    {
        public override Burger createBurger()
        {
            return new DeluxeBurgerBuilder();
        }

        public override Pizza createPizza()
        {
            return new DeluxePizzaBuilder();
        }
    }
}
