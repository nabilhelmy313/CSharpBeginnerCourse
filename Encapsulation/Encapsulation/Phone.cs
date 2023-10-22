namespace Encapsulation
{
    public class Phone : Product
    {
        protected void ProtectedMethod()
        {
            base.ProtectedMethod();
        }
        public void AccessProductMembers()
        {

            // Accessing members of Product from ClassB
            PublicField = 1;          // PublicField is accessible
            base.PublicMethod();           // PublicMethod is accessible

            // PrivateField and PrivateMethod are not accessible from ClassB
            // base.PrivateField = 2; // Compilation error
            // base.PrivateMethod(); // Compilation error

            base.ProtectedField = 3;       // ProtectedField is accessible within the same assembly
            base.ProtectedMethod();        // ProtectedMethod is accessible within the same assembly

            base.InternalField = 4;        // InternalField is accessible within the same assembly
            base.InternalMethod();         // InternalMethod is accessible within the same assembly

            base.ProtectedInternalField = 5; // ProtectedInternalField is accessible within the same assembly
            base.ProtectedInternalMethod();  // ProtectedInternalMethod is accessible within the same assembly
        }
    }
}
