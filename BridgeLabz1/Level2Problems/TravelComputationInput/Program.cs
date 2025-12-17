using System;

class TravelComputationInput
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("From city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("To city: ");
        string toCity = Console.ReadLine();

        Console.Write("Distance from to via (km): ");
        double d1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Distance via to final (km): ");
        double d2 = Convert.ToDouble(Console.ReadLine());

        double totalDistance = d1 + d2;

        Console.WriteLine($"{name} travelled {totalDistance} km from {fromCity} to {toCity} via {viaCity}");
    }
}
