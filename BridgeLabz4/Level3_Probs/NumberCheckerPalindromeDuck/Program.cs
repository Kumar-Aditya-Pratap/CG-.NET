using System;

class NumberCheckerPalindromeDuck
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

    static bool IsPalindrome(int[] digits)
    {
        int i = 0, j = digits.Length - 1;
        while (i < j)
        {
            if (digits[i] != digits[j]) return false;
            i++; j--;
        }
        return true;
    }

    static bool IsDuck(int[] digits)
    {
        foreach (int d in digits)
            if (d != 0) return true;
        return false;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int[] digits = GetDigits(number);

        Console.WriteLine("Palindrome: " + IsPalindrome(digits));
        Console.WriteLine("Duck Number: " + IsDuck(digits));
    }
}
