global using static System.Console;

Write("Enter count of printing : ");
int forCount = int.Parse(ReadLine());

// Using a for loop
for (int i = 0; i < forCount; i++)
{
    WriteLine($"hi from For loop {i + 1}");
}

// Using a while loop
Write("Enter count of printing : ");
int whileCount = int.Parse(ReadLine());

int j = 0;
while (j < whileCount)
{
    WriteLine($"Welcome form while {j}");
    j++;
}
// Using a do-while loop
Write("Enter count of printing : ");
int doWhileCount = int.Parse(ReadLine());
int k = 0;
do
{
    WriteLine($"Welcome From DO While {k + 1}");
    k++;
} while (k < doWhileCount);
