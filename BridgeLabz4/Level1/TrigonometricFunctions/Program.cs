using System;

class TrigonometricFunctions
{
    static double[] CalculateTrigonometricFunctions(double angle)
    {
        double radians = angle * Math.PI / 180;
        return new double[]
        {
            Math.Sin(radians),
            Math.Cos(radians),
            Math.Tan(radians)
        };
    }

    static void Main()
    {
        Console.Write("Enter angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        double[] result = CalculateTrigonometricFunctions(angle);

        Console.WriteLine($"Sin: {result[0]}");
        Console.WriteLine($"Cos: {result[1]}");
        Console.WriteLine($"Tan: {result[2]}");
    }
}
