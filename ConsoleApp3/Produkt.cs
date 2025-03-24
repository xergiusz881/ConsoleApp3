using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     class Produkt
    {
        public string BarCode;
        public string Name;
        public double Price;

        public Produkt(string barCode, string name, double price)
        {
            BarCode = barCode;
            Name = name;
            Price = price;
        }
    }
}
