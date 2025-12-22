using System;

class OddEvenArrays
{
    static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");

        if (!int.TryParse(Console.ReadLine(), out int number) || number <= 0)
        {
            Console.Error.WriteLine("Invalid number.");
            Environment.Exit(1);
        }

        int[] odd = new int[number / 2 + 1];
        int[] even = new int[number / 2 + 1];
        int o = 0, e = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
                even[e++] = i;
            else
                odd[o++] = i;
        }

        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < o; i++)
            Console.Write(odd[i] + " ");

        Console.WriteLine("\nEven Numbers:");
        for (int i = 0; i < e; i++)
            Console.Write(even[i] + " ");
    }
}
