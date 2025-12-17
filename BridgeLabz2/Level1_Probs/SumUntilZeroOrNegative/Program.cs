using System;

class SumUntilZeroOrNegative
{
    static void Main()
    {
        double total = 0;

        while (true)
        {
            Console.Write("Enter number: ");
            double input = double.Parse(Console.ReadLine());

            if (input <= 0)
                break;

            total += input;
        }

        Console.WriteLine($"Total sum: {total}");
    }
}
