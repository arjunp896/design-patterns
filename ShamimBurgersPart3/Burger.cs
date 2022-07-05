using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamimBurgersPart3
{
    class Burger
    {
        private string name;
        private string rollType;
        private string meat;
        private double price;
        private double totalPrice;

        private List<KeyValuePair<string, double>> additions = new List<KeyValuePair<string, double>>();

        public Burger(string name, string rollType, string meat, double price)
        {
            this.name = name;
            this.rollType = rollType;
            this.meat = meat;
            this.price = price;
            totalPrice = price;
        }

        public void addExtra(KeyValuePair<string, double> addition)
        {
            additions.Add(addition);
            totalPrice += addition.Value;
        }

        public int getTotalExtras()
        {
            return additions.Count();
        }

        public String Name
        {
            get { return name; }
        }

        public String RollType
        {
            get { return rollType; }
        }
        public String Meat
        {
            get { return meat; }
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
        public List<KeyValuePair<string, double>> Additions
        {
            get { return additions; }
        }

        public List<KeyValuePair<string, double>> getAdditions()
        {
            return additions;
        }
    }
}
