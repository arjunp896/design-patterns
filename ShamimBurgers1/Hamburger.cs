using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamimBurgers1
{
    class Hamburger
    {
        private string name;
        private string rollType;
        private string meat;
        private double price;
        private double totalPrice;

        private List<KeyValuePair<string, double>> additions = new List<KeyValuePair<string, double>>();

        public Hamburger(string name, string rollType, string meat, double price)
        {
            this.name = name;
            this.rollType = rollType;
            this.meat = meat;
            this.price = price;
            totalPrice = price;
        }

        public void addAddition(KeyValuePair<string, double> addition)
        {
            additions.Add(addition);
            totalPrice += addition.Value;
        }

        public int getTotalAdditionAdded()
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
        public double TotalPrice
        {
            get { return totalPrice; }
        }
        public List<KeyValuePair<string, double>> Additions
        {
            get { return additions; }
        }
    }
}
