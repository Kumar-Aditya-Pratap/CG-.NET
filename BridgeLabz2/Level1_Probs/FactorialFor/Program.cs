using System;

class FactorialFor
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        int fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;

        Console.WriteLine($"Factorial of {n} is {fact}");
    }
}
