using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamimBurgers2
{
    class HealthyPizzaBuilder : Pizza
    {
        public override void display()
        {
            Console.WriteLine("Healthy Pizza");
        }
    }
}
