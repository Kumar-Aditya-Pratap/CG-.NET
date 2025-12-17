using System;

class RocketCountdownWhile
{
    static void Main()
    {
        Console.Write("Enter countdown start: ");
        int counter = int.Parse(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }
}
