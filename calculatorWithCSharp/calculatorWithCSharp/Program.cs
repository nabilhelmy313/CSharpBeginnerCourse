global using static System.Console;

WriteLine("Console Calculator");
Write("Enter the first number: ");
var isNumber1 = double.TryParse(ReadLine(), out double num1);
if (isNumber1)
{
    Write("Enter an operator (+, -, *, /): ");
    char op = ReadLine()[0];

    Write("Enter the second number: ");
    var isNumber2 = double.TryParse(ReadLine(), out double num2);
    if (isNumber2)
    {
        double result = 0.0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                    WriteLine("Error: Division by zero.");
                break;
            default:
                WriteLine("Error: Invalid operator.");
                break;
        }

        WriteLine($"Result: {num1} {op} {num2} = {result}");
    }
    else
    {
        WriteLine("Error: Invalid second number.");
    }
}
else
{
    WriteLine("invalid Charachter");
}
ReadKey();
