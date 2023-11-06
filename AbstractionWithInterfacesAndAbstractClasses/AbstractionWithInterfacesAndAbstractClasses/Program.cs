global using static System.Console;
using AbstractionWithInterfacesAndAbstractClasses;

Phone iphone = new Phone("iPhone 13", 999.99, "13 Pro");
iphone.DiscountPercentage = 15; // Apply a 15% discount
iphone.ApplyDiscount(); // Apply the discount

Book novel = new Book("Great Expectations", 19.99, "Charles Dickens");

WriteLine($"{iphone.Name} ({iphone.Model}) Price: ${iphone.Price}, Tax: ${iphone.CalculateTax()}");
WriteLine($"{novel.Name} by {novel.Author} Price: ${novel.Price}, Tax: ${novel.CalculateTax()}");
