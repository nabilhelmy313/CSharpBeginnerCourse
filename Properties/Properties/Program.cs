global using static System.Console;
using Properties;

Product product = new ();

// Set values for the properties
product.PropertyName = "Example Product";
product.Quantity = 10;
product.Price = 100.0;
product.SetDescription("This is an example product.");

// Display the property values and description
WriteLine("Product Name: " + product.PropertyName);
WriteLine("Quantity: " + product.Quantity);
WriteLine("Price: " + product.Price);
WriteLine("Description: " + product.GetDescription());// the get accessor is invoked here



