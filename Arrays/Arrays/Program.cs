global using static System.Console;
// Declare and initialize an array.
string[] weekDays = { "Sat", "Sun", "Mon", "Tue", "Wed", "Thu", "Fri" };
for (int i = 0; i < weekDays.Length; i++)
{
    WriteLine($"Hi I am {weekDays[i]}");
}


int[] simpleIntArray = new int[4];
simpleIntArray[0] = 1;
simpleIntArray[1] = 2;
simpleIntArray[2] = 3;
simpleIntArray[3] = 4;


int[,] array2DInitialization = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
int[,] multiDimensionArray = new int[3, 2];
// Filling the array
multiDimensionArray[0, 0] = 1;
multiDimensionArray[0, 1] = 2;
multiDimensionArray[1, 0] = 3;
multiDimensionArray[1, 1] = 4;
multiDimensionArray[2, 0] = 5;
multiDimensionArray[2, 1] = 6;
for (int i = 0; i < multiDimensionArray.GetLength(0); i++)
{
    for (int j = 0; j < multiDimensionArray.GetLength(1); j++)
    {
        WriteLine(multiDimensionArray[i, j]);
    }
}

int[][] jaggedArray = new int[2][];
jaggedArray[0] = new int[3];
jaggedArray[1] = new int[5];
jaggedArray[0] = new int[] { 3, 5, 7, };
jaggedArray[1] = new int[] { 1, 0, 2, 4, 6 };

// Iterate through the jagged array and print its elements
for (int i = 0; i < jaggedArray.Length; i++)
{
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write(jaggedArray[i][j] + " ");
    }
    Console.WriteLine(); // Move to the next row
}

//implicitly array
var a = new[] { 1, 10, 100, 1000 }; // int[]
// Accessing array
WriteLine("First element: " + a[0]);
WriteLine("Second element: " + a[1]);
WriteLine("Third element: " + a[2]);
WriteLine("Fourth element: " + a[3]);