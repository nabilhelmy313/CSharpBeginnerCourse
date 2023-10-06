global using static System.Console;
using ClassesAndObject;
Product pen = new Product();
pen.Name = "Pen 1";
pen.Price = 10.5;

Product notebook = new Product();
notebook.Name = "Note Book";
notebook.Price = 15;
WriteLine($"Pen Name is {pen.Name} & {pen.Price}  EGP ");
WriteLine($"The Notebook Name is" +
    $" {notebook.Name} & {notebook.Price}  EGP ");



