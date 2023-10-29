using InheritanceAndPolymorphism;

Product laptop = new Product();
laptop.Price = 100;
laptop.Quantity = 2;
var sumLaptop= laptop.SumPrice();
Console.WriteLine(sumLaptop);

Phone phone = new Phone();
phone.Price = 100;
phone.Quantity = 2;
phone.Color = "Pink";

