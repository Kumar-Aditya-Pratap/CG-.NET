using System;

class CollinearPoints
{
    static bool IsCollinear(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return area == 0;
    }

    static void Main()
    {
        Console.Write("Enter x1 y1 x2 y2 x3 y3: ");
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Collinear: " + IsCollinear(x1, y1, x2, y2, x3, y3));
    }
}
