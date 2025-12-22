using System;

class RemoveSpecificCharacter
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        Console.Write("Enter character to remove: ");
        char remove = Console.ReadLine()[0];

        string result = "";

        foreach (char c in input)
            if (c != remove)
                result += c;

        Console.WriteLine("Modified String: " + result);
    }
}
