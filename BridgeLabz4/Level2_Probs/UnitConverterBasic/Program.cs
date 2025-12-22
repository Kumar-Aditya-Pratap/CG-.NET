using System;

class UnitConverterBasic
{
    static double FeetToInch(double feet) => feet * 12;
    static double InchToFeet(double inch) => inch / 12;

    static void Main()
    {
        Console.Write("Enter feet: ");
        double feet = double.Parse(Console.ReadLine());
        Console.WriteLine($"Inches: {FeetToInch(feet)}");

        Console.Write("Enter inches: ");
        double inch = double.Parse(Console.ReadLine());
        Console.WriteLine($"Feet: {InchToFeet(inch)}");
    }
}
