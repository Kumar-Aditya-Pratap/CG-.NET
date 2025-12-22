using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] chars = input.ToCharArray();
        int i = 0, j = chars.Length - 1;

        while (i < j)
        {
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
            i++; j--;
        }

        Console.WriteLine("Reversed String: " + new string(chars));
    }
}
