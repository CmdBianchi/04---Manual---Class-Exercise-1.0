using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Stock {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public Stock() { }
        public Stock(string name, double price, int amount) {
            Name = name;
            Price = price;
            Amount = amount;
        }
        public double TotalInSotock() {
            return Amount * Price;
        }
        public void AddProduct(int amount) {
            Amount += amount;
        }
        public void RemoveProduct(int amount) {
            Amount -= amount;
        }

        public override string ToString() {
            return Name + ", $" + Price.ToString("F2") + ", " + Amount + " valor das unidades no estoque, TOTAL: $" + TotalInSotock().ToString("F2");

        }
    }
}
