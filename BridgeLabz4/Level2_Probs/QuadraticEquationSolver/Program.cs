using System;

class QuadraticEquationSolver
{
    static void Solve(double a, double b, double c)
    {
        double d = b * b - 4 * a * c;

        if (d > 0)
        {
            double r1 = (-b + Math.Sqrt(d)) / (2 * a);
            double r2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"Roots: {r1}, {r2}");
        }
        else if (d == 0)
        {
            double r = -b / (2 * a);
            Console.WriteLine($"Root: {r}");
        }
        else
        {
            Console.WriteLine("No real roots");
        }
    }

    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        Solve(a, b, c);
    }
}
