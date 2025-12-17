using System;

class FactorialWhile
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        int fact = 1, i = 1;
        while (i <= n)
        {
            fact *= i;
            i++;
        }

        Console.WriteLine($"Factorial of {n} is {fact}");
    }
}
