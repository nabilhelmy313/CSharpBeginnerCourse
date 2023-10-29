namespace InheritanceAndPolymorphism
{
    internal class Phone : Product
    {
        public string Color { get; set; } = string.Empty;
        public override double SumPrice()
        {
            return Price * Quantity * +(Price * .14);
        }
        public new void PrintName(string name)
        {
            Console.WriteLine("Print some thing eles than other method"+name);
        }
    }
}
