using System;

class SumUntilZero
{
    static void Main()
    {
        double total = 0;
        double input;

        while (true)
        {
            Console.Write("Enter number (0 to stop): ");
            input = double.Parse(Console.ReadLine());

            if (input == 0)
                break;

            total += input;
        }

        Console.WriteLine($"Total sum: {total}");
    }
}
