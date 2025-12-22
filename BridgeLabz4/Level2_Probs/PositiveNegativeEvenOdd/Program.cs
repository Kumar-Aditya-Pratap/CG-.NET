using System;

class PositiveNegativeEvenOdd
{
    static void CheckNumber(int number)
    {
        if (number > 0)
            Console.WriteLine(number % 2 == 0 ? "Positive Even" : "Positive Odd");
        else if (number < 0)
            Console.WriteLine("Negative Number");
        else
            Console.WriteLine("Zero");
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        CheckNumber(number);
    }
}
