using System;

class RocketCountdownFor
{
    static void Main()
    {
        Console.Write("Enter countdown start: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = number; i >= 1; i--)
            Console.WriteLine(i);
    }
}
