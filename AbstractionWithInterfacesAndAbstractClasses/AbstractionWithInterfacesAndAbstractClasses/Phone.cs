using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithInterfacesAndAbstractClasses
{

    internal class Phone : Product, IDiscountable
    {
        public string Model { get; set; }

        public double DiscountPercentage { get; set; }

        public Phone(string name, double price, string model) : base(name, price)
        {
            Model = model;
        }

        public override double CalculateTax()
        {
            // Calculate tax for phones
            return Price * 0.1; // 10% tax
        }

        public void ApplyDiscount()
        {
            // Apply a discount to the phone's price
            Price = Price - (Price * DiscountPercentage / 100);
        }
    }
}
