using System;

class SumOfNNaturalWhile
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            int sum = 0, i = 1;
            while (i <= n)
            {
                sum += i;
                i++;
            }

            int formula = n * (n + 1) / 2;
            Console.WriteLine($"While loop sum: {sum}");
            Console.WriteLine($"Formula sum: {formula}");
        }
    }
}
