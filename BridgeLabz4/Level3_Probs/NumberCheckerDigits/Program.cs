using System;

class NumberCheckerDigits
{
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

    static bool IsDuck(int[] digits)
    {
        foreach (int d in digits)
            if (d != 0) return true;
        return false;
    }

    static bool IsArmstrong(int number, int[] digits)
    {
        int power = digits.Length;
        int sum = 0;
        foreach (int d in digits)
            sum += (int)Math.Pow(d, power);
        return sum == number;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int count = CountDigits(number);
        int[] digits = GetDigits(number, count);

        Console.WriteLine("Duck Number: " + IsDuck(digits));
        Console.WriteLine("Armstrong Number: " + IsArmstrong(number, digits));
    }
}
