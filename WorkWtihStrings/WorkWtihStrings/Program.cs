string hello = "Hello, World!";
Console.WriteLine(hello);

string firstName = "Nabil";
string lastName = "Helmy";
string fullName = firstName + " " + lastName; // Concatenation
Console.WriteLine(fullName);

string helloNabil = "Hello, Nabil!";
string nabil = helloNabil.Substring(7, 5); // sub is "Hello"
Console.WriteLine(nabil);

string name = "Ahmed";
int age = 30;
string message = $"My name is {name} and I am {age} years old.";//string Interpolation
Console.WriteLine(message);
Console.WriteLine(message + message.Length);

string original = "  Hello, World!  ";
string trimmed = original.Trim(); // Removes leading and trailing whitespace
Console.WriteLine(trimmed);

string replaced = original.Replace("World", "Universe");
Console.WriteLine(replaced);
bool containsText = message.Contains("sample");//contain this text
Console.WriteLine($"is contain {containsText}");
