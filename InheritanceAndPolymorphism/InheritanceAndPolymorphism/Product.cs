namespace InheritanceAndPolymorphism
{
    internal class Product
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public virtual double SumPrice()
        {
            return Price * Quantity;
        }
        public virtual string SumPrice(string name)
        {
            return $"{name} is {(Price * Quantity).ToString)}";
        }
    }
}
