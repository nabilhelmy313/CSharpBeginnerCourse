global using static System.Console;//.net 7 feature
int number = 10;

if (number > 0)
{
    WriteLine("The number is positive.");
}
else if (number == 0)
{
    WriteLine("The number is zero.");
}
else
{
    WriteLine("The number is negative.");
}

// Nested if statements
int age = 25;
bool isStudent = true;

if (age >= 18)
{
    WriteLine("You are an adult.");

    if (isStudent)
    {
        WriteLine("You are a student.");
    }
    else
    {
        WriteLine("You are not a student.");
    }
}
else
{
    Console.WriteLine("You are a minor.");
}

// Ternary conditional operator
int x = 5;
int y = 10;
string result = (x > y) ? "x is greater" : "y is greater";
WriteLine(result);






