global using static System.Console;
void PrintHelloWithName(string name)
{
    WriteLine($"Hello {name}");
}
double SumTwoNumbers(double firstNumber, double secondNumber)
{
    double result;
    result = firstNumber + secondNumber;
    return result;
}
//use Void Method
Write("Enter your Name ");

string yourName = ReadLine()!;
if (string.IsNullOrEmpty(yourName))
    WriteLine("please Put Name");
else
    PrintHelloWithName(yourName);

//use the Return Method
Write("Enter the first number = ");
bool isNumber1 = double.TryParse(ReadLine(), out double firstNumber);
Write("Enter the second number = ");
bool isNumber2 = double.TryParse(ReadLine(), out double secondNumber);
if (isNumber1 && isNumber2)
{
    double result = SumTwoNumbers(firstNumber, secondNumber);
    WriteLine($"result {firstNumber} + {secondNumber} = {result}");
}
else
    WriteLine("Please enter valid number");


