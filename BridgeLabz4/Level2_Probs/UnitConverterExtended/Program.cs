using System;

class UnitConverterExtended
{
    static double FeetToMeter(double feet) => feet * 0.3048;
    static double MeterToFeet(double meter) => meter / 0.3048;

    static void Main()
    {
        Console.Write("Enter feet: ");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine($"Meters: {FeetToMeter(feet)}");

        Console.Write("Enter meters: ");
        double meter = double.Parse(Console.ReadLine());
        Console.WriteLine($"Feet: {MeterToFeet(meter)}");
    }
}
