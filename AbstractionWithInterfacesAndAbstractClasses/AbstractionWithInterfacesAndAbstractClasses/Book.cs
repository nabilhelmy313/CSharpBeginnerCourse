using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithInterfacesAndAbstractClasses
{
    internal class Book : Product
    {
        public string Author
        {
            get; set;
        }
        public Book(string name, double price, string author) : base(name, price)
        {
            Author = author;
        }

        public override double CalculateTax()
        {
            // Calculate tax for books
            return 0; // Books are tax-exempt
        }
    }
}
