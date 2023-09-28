
Console.WriteLine("Console Calculator");
Console.WriteLine("Enter 'q' to quit.");
Console.Write("Enter the first number: ");

if (double.TryParse(Console.ReadLine(), out double num1))
{
    Console.Write("Enter an operator (+, -, *, /): ");
    char op = Console.ReadLine()[0];

    Console.Write("Enter the second number: ");

    if (double.TryParse(Console.ReadLine(), out double num2))
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
                    Console.WriteLine("Error: Division by zero.");
                break;
            default:
                Console.WriteLine("Error: Invalid operator.");
                break;
        }

        Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
    }
    else
    {
        Console.WriteLine("Error: Invalid second number.");
    }
}
Console.WriteLine("\nPress Enter to continue...");
Console.ReadLine();
Console.Clear();
