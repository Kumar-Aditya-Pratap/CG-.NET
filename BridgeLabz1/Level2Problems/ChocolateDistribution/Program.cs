using System;

class ChocolateDistribution
{
    static void Main()
    {
        Console.Write("Enter number of chocolates: ");
        int chocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int children = Convert.ToInt32(Console.ReadLine());

        int each = chocolates / children;
        int remaining = chocolates % children;

        Console.WriteLine($"Each child gets {each} chocolates and remaining are {remaining}");
    }
}
