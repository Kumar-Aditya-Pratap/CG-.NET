using System;

class OddEvenNumbers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
            Console.WriteLine($"{i} is {(i % 2 == 0 ? "Even" : "Odd")}");
    }
}
