using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithInterfacesAndAbstractClasses
{
    internal interface IDiscountable
    {
        double DiscountPercentage { get; set; }
        void ApplyDiscount();
    }
}
