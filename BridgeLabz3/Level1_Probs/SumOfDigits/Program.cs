using System;

class SumOfDigits
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");

        if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
        {
            Console.Error.WriteLine("Invalid number entered.");
            Environment.Exit(1);
        }

        int temp = number;
        int count = 0;

        while (temp > 0)
        {
            count++;
            temp /= 10;
        }

        int[] digits = new int[count];

        for (int i = 0; i < digits.Length; i++)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }

        Console.WriteLine($"Sum of digits: {sum}");
    }
}
