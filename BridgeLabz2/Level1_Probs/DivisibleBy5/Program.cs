using System;

class DivisibleBy5
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isDivisible = number % 5 == 0;
        Console.WriteLine($"Is the number {number} divisible by 5? {isDivisible}");
    }
}
