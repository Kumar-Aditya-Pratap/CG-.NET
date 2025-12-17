using System;

class SumOfNNaturalFor
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += i;

            int formula = n * (n + 1) / 2;
            Console.WriteLine($"For loop sum: {sum}");
            Console.WriteLine($"Formula sum: {formula}");
        }
    }
}
