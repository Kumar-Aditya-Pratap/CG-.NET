using System;

class ToggleCase
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            result[i] = char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
        }

        Console.WriteLine("Toggled String: " + new string(result));
    }
}
