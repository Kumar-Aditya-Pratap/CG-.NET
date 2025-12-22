using System;

class SubstringOccurrences
{
    static void Main()
    {
        Console.Write("Enter main string: ");
        string main = Console.ReadLine();

        Console.Write("Enter substring: ");
        string sub = Console.ReadLine();

        int count = 0;

        for (int i = 0; i <= main.Length - sub.Length; i++)
        {
            if (main.Substring(i, sub.Length) == sub)
                count++;
        }

        Console.WriteLine("Occurrences: " + count);
    }
}
