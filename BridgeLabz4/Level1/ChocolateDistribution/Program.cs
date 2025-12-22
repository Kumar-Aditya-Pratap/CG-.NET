using System;

class ChocolateDistribution
{
    static int[] FindRemainderAndQuotient(int chocolates, int children)
    {
        return new int[] { chocolates / children, chocolates % children };
    }

    static void Main()
    {
        Console.Write("Enter chocolates: ");
        int chocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter children: ");
        int children = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(chocolates, children);
        Console.WriteLine($"Each child gets {result[0]} chocolates, Remaining: {result[1]}");
    }
}
