using ExceptionHandling;

try
{

    string name =Console.ReadLine();
    Product product = new Product();
    Console.WriteLine($"Result: {product.Name[1]}");
    product.Name = name;
    Console.WriteLine($"Result: {product.Name[2]}");
}
catch (NullReferenceException )
{
    // Handle the specific exception
    Console.WriteLine("Error: NullReferenceException");
}
catch (Exception ex)
{
    // Handle other exceptions
    throw;
    //Console.WriteLine($"An error occurred: {ex.Message}");
}
finally
{
    // This block always executes, even if there's no exception
    Console.WriteLine("Finally block executed");
}