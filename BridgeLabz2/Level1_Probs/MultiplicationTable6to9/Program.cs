using System;

class MultiplicationTable6to9
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 6; i <= 9; i++)
            Console.WriteLine($"{number} * {i} = {number * i}");
    }
}
