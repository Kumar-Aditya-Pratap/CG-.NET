using System;

class Program
{
    static void Main()
    {
        double radiusKm = 6378;
        double pi = Math.PI;

        double volumeKm = (4.0 / 3.0) * pi * Math.Pow(radiusKm, 3);
        double volumeMiles = volumeKm / Math.Pow(1.6, 3);

        Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKm}");
        Console.WriteLine($"The volume of earth in cubic miles is {volumeMiles}");
    }
}
