using System;

class PoundsToKilograms
{
    static void Main()
    {
        Console.Write("Enter weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());

        double kg = pounds / 2.2;

        Console.WriteLine($"{pounds} pounds is {kg} kilograms");
    }
}
