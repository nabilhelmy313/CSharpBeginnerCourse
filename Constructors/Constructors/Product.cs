using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Product
    {
        public readonly string name=string.Empty;
        public readonly int quantity;
        public readonly double price;
        public Product()
        {

        }
        public Product(string productName)
        {
            Console.WriteLine($"{productName}");
        }
        public Product(int quantity, double price)
        {
            this.quantity = quantity;
            this.price = price;
        }

        public void PrintAll()
        {
            Console.WriteLine($"The product is {name}the quantity is {quantity} and price is {price}");
        }
    }
}
