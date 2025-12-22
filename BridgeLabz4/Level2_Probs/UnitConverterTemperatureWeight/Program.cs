using System;

class UnitConverterTemperatureWeight
{
    static double CelsiusToFahrenheit(double c) => (c * 9 / 5) + 32;
    static double KilogramToPound(double kg) => kg * 2.20462;

    static void Main()
    {
        Console.Write("Enter Celsius: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine($"Fahrenheit: {CelsiusToFahrenheit(c)}");

        Console.Write("Enter Kilograms: ");
        double kg = double.Parse(Console.ReadLine());
        Console.WriteLine($"Pounds: {KilogramToPound(kg)}");
    }
}
