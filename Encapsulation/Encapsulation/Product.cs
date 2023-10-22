namespace Encapsulation
{
    public class Product
    {
        public int PublicField;  // Accessible from anywhere in the same assembly
        private int PrivateField=5; // Accessible only within Product
        internal int InternalField; // Accessible within the same assembly
        protected int ProtectedField; // Accessible within Product and its derived classes
        protected internal int ProtectedInternalField; // Accessible within the same assembly and derived classes

        public void PublicMethod()
        {
            Console.WriteLine("Public method in Product");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("Private method in Product");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method in Product");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("Internal method in Product");
        }

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected Internal method in Product");
        }
    }
}
