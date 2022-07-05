using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamimBurgers1
{
    class Constants
    {
        public const string BASIC_ROLL_TYPE = "White roll";
        public const string HEALTHY_ROLL_TYPE = "Brown rye roll";
        public const string DELUXE_ROLL_TYPE = "White roll";

        public const string BASIC_MEAT = "Sausage";
        public const string HEALTHY_MEAT = "Bacon";
        public const string DELUXE_MEAT = "Sausage & Bacon";

        public const double BASIC_BURGER_PRICE = 3.56;
        public const double HEALTHY_BURGER_PRICE = 5.67;
        public const double DELUXE_BURGER_PRICE = 14.54;

        public const int BASIC_MAX_ADDITIONS = 4;
        public const int HEALTHY_MAX_ADDITIONS = 6;

        public static List<KeyValuePair<string, double>> ADDITIONS = new List<KeyValuePair<string, double>>()
                                                {
                                                    new KeyValuePair<string, double>("Tomato", 0.27),
                                                    new KeyValuePair<string, double>("Lettuce", 0.75),
                                                    new KeyValuePair<string, double>("Cheese", 1.13),
                                                    new KeyValuePair<string, double>("Egg", 5.43),
                                                    new KeyValuePair<string, double>("Lentils", 3.41),
                                                    new KeyValuePair<string, double>("Chips", 2.75),
                                                    new KeyValuePair<string, double>("Drink", 1.81)
                                                };
    }
}
