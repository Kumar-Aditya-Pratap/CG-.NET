using System;

class SimpleInterest
{
    static void Main()
    {
        Console.Write("Enter principal: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time: ");
        double time = Convert.ToDouble(Console.ReadLine());

        double si = (principal * rate * time) / 100;

        Console.WriteLine($"Simple Interest is {si}");
    }
}
