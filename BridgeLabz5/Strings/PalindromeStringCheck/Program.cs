using System;

class PalindromeStringCheck
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int i = 0, j = input.Length - 1;
        bool isPalindrome = true;

        while (i < j)
        {
            if (input[i] != input[j])
            {
                isPalindrome = false;
                break;
            }
            i++; j--;
        }

        Console.WriteLine(isPalindrome ? "Palindrome" : "Not a Palindrome");
    }
}
