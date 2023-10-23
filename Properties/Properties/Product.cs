namespace Properties
{
    internal class Product
    {
        // the name field
        private string _name;
        private double _price;
        private string _description;
        // the Name property For Get
        public string PropertyName { get => _name; set => _name = value; }
        public int Quantity { get; set; }
        public double Price
        {
            get { return _price; }
            set { _price = value * value * 0.14; }
        }

        public string GetDescription()
        {
            return _description;
        }
        public void SetDescription(string description)
        {
            _description = description;
        }

    }
}
