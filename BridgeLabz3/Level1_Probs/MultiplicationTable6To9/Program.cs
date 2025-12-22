using System;

class MultiplicationTable6To9
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");

        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.Error.WriteLine("Invalid input.");
            Environment.Exit(1);
        }

        int[] result = new int[4];
        int index = 0;

        for (int i = 6; i <= 9; i++)
        {
            result[index++] = number * i;
        }

        index = 0;
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {result[index++]}");
        }
    }
}
