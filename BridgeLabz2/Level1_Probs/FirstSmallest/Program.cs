using System;

class SmallestOfThree
{
    static void Main()
    {
        Console.Write("Enter three numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        bool isSmallest = a < b && a < c;
        Console.WriteLine($"Is the first number the smallest? {isSmallest}");
    }
}
