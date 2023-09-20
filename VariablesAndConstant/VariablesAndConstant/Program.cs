
//Typed variables
int age; // Declaration
age = 25; // Assignment
Console.WriteLine($"My age is {age}"); // Output: My age is 25

//multi varibles in same line
string firstName, lastName;
firstName = "Nabil";
lastName = "Helmy";
Console.WriteLine($"my Name is {firstName} {lastName}");

//var Example
var dateAndTimeOftheDay = DateTime.Now;
Console.WriteLine($"today Date is {dateAndTimeOftheDay}");
//Constant 
const double Pi = 3.14159265359; // Declaration and assignment
double radius = 5.0;
double area = Pi * radius * radius; // Calculating the area of a circle
Console.WriteLine($"The area of the circle is {area} square units"); // Output: The area of the circle is 78.5398163397448 square units
Console.ReadKey();