using System;

class NumberCheckerHarshadFrequency
{
    static int[] GetDigits(int number)
    {
        int temp = number, count = 0;
        while (temp > 0) { count++; temp /= 10; }

        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    static bool IsHarshad(int number, int[] digits)
    {
        int sum = 0;
        foreach (int d in digits) sum += d;
        return number % sum == 0;
    }

    static void DigitFrequency(int[] digits)
    {
        int[,] freq = new int[10, 2];

        for (int i = 0; i < 10; i++)
            freq[i, 0] = i;

        foreach (int d in digits)
            freq[d, 1]++;

        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
            if (freq[i, 1] > 0)
                Console.WriteLine(freq[i, 0] + " -> " + freq[i, 1]);
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int[] digits = GetDigits(number);

        Console.WriteLine("Harshad Number: " + IsHarshad(number, digits));
        DigitFrequency(digits);
    }
}
