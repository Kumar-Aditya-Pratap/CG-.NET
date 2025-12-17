using System;

class YoungestAndTallest
{
    static void Main()
    {
        Console.Write("Amar age & height: ");
        int aAge = int.Parse(Console.ReadLine());
        double aHeight = double.Parse(Console.ReadLine());

        Console.Write("Akbar age & height: ");
        int bAge = int.Parse(Console.ReadLine());
        double bHeight = double.Parse(Console.ReadLine());

        Console.Write("Anthony age & height: ");
        int cAge = int.Parse(Console.ReadLine());
        double cHeight = double.Parse(Console.ReadLine());

        int youngest = Math.Min(aAge, Math.Min(bAge, cAge));
        double tallest = Math.Max(aHeight, Math.Max(bHeight, cHeight));

        Console.WriteLine($"Youngest age: {youngest}");
        Console.WriteLine($"Tallest height: {tallest}");
    }
}
