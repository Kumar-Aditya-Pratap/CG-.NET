using System;

class FahrenheitToCelsius
{
    static void Main()
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"{fahrenheit} Fahrenheit is {celsius} Celsius");
    }
}
