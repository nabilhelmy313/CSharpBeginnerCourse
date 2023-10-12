using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Product
    {
        public Product()
        {

        }
        public Product(string productName)
        {
            Console.WriteLine($"{productName}");
        }
    }
}
