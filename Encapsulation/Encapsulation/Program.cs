using Encapsulation;

Product product = new ();

// Accessing Product members from the Main method (within the same assembly)
product.PublicField = 10;
product.PublicMethod();

product.ProtectedInternalMethod();
// Other members (private, protected, internal) are not accessible from Main.
// Product.PrivateField = 20; // Compilation error
// Product.ProtectedField = 30; // Compilation error
//Product.InternalField = 40; // Compilation error
    
