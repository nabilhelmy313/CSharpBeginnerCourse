namespace AbstractionWithInterfacesAndAbstractClasses
{
    internal abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // Abstract method to calculate tax
        public abstract double CalculateTax();
    }
}
