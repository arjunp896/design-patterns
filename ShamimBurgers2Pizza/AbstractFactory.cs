using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamimBurgers2
{
    abstract class AbstractFactory
    {
        private static BasicBuilder basicBuilder = new BasicBuilder();
        private static DeluxeBuilder deluxeBuilder = new DeluxeBuilder();
        private static HealthyBuilder healthyBuilder = new HealthyBuilder();


        public static AbstractFactory getFactory(BuilderType type)
        {
            AbstractFactory abstractFactory = null;
            switch (type)
            {
                case BuilderType.BASIC:

                    abstractFactory = basicBuilder;
                    break;
                    
                case BuilderType.HEALTHY:
                    abstractFactory = healthyBuilder;
                    break;

                case BuilderType.DELUXE:
                    abstractFactory = deluxeBuilder;
                    break;
            }

            return abstractFactory;
        }

        public abstract Pizza createPizza();
        public abstract Burger createBurger();
    }
}
