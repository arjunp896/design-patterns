using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamimBurgersPart3
{
    class Pizza
    {
        private string name;
        private string baseType;
        private string cheeseType;
        private double price;
        private double totalPrice;

        private List<KeyValuePair<string, double>> toppings = new List<KeyValuePair<string, double>>();
        public Pizza(string name, string baseType, string cheeseType, double price)
        {
            this.name = name;
            this.baseType = baseType;
            this.cheeseType = cheeseType;
            this.price = price;
            totalPrice = price;
        }

        public void addExtra(KeyValuePair<string, double> topping)
        {
            toppings.Add(topping);
            totalPrice += topping.Value;
        }

        public int getTotalExtras()
        {
            return toppings.Count();
        }

        public String Name
        {
            get { return name; }
        }

        public String BaseType
        {
            get { return baseType; }
        }
        public String CheeseType
        {
            get { return cheeseType; }
        }

        public double Price
        {
            get { return price; }
        }
        public double getTotalPrice()
        {
            return totalPrice;
        }
        public double TotalPrice
        {
            get { return totalPrice; }
        }
        public List<KeyValuePair<string, double>> Toppings
        {
            get { return toppings; }
        }

        public List<KeyValuePair<string, double>> getAdditions()
        {
            return toppings;
        }

    }
}
