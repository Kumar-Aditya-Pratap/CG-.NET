using System;

class SumOfDigitsRandom
{
    static int Get4DigitRandomNumber()
    {
        Random random = new Random();
        return random.Next(1000, 10000);
    }

    static int CountDigits(int number)
    {
        int count = 0;
        while (number > 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    static int[] GetDigits(int number, int count)
    {
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    static int SumArray(int[] array)
    {
        int sum = 0;
        foreach (int d in array)
            sum += d;
        return sum;
    }

    static void Main()
    {
        int number = Get4DigitRandomNumber();
        Console.WriteLine("Random Number: " + number);

        int count = CountDigits(number);
        int[] digits = GetDigits(number, count);

        Console.WriteLine("Sum of Digits: " + SumArray(digits));
    }
}
