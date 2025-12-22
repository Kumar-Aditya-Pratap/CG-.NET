using System;

class TriangularParkRun
{
    static double CalculateRounds(double a, double b, double c)
    {
        double perimeter = a + b + c;
        return 5000 / perimeter;
    }

    static void Main()
    {
        Console.Write("Enter side 1: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double c = double.Parse(Console.ReadLine());

        double rounds = CalculateRounds(a, b, c);
        Console.WriteLine($"Rounds required to complete 5 km: {rounds}");
    }
}
