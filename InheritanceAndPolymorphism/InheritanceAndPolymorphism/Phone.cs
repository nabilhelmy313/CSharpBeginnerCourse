namespace InheritanceAndPolymorphism
{
    internal class Phone : Product
    {
        public string Color { get; set; } = string.Empty;
        public override double SumPrice()
        {
            return Price * Quantity * +(Price * .14);
        }
    }
}
