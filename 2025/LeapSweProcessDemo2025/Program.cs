Console.WriteLine("Welcome to the SWE Process Demo!");

int num1 = 10;
int num2 = 20;
int sum = AddNumbers(num1, num2);

Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
Console.WriteLine("Press any key to continue...");
Console.ReadKey();

int AddNumbers(int a, int b)
{
    return a + b;
}

int SubtractNumbers(int a, int b)
{
    return a - b;
}
