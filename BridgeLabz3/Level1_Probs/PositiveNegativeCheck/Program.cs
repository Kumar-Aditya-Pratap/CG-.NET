using System;

class PositiveNegativeCheck
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 numbers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Error.WriteLine("Invalid input.");
                Environment.Exit(1);
            }
        }

        foreach (int num in numbers)
        {
            if (num > 0)
            {
                Console.WriteLine(num % 2 == 0 ? $"{num} is Positive Even" : $"{num} is Positive Odd");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        int first = numbers[0];
        int last = numbers[numbers.Length - 1];

        if (first == last)
            Console.WriteLine("First and Last elements are Equal");
        else if (first > last)
            Console.WriteLine("First element is Greater");
        else
            Console.WriteLine("Last element is Greater");
    }
}
