using System;

class MostFrequentCharacter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int[] freq = new int[256];

        foreach (char c in input)
            freq[c]++;

        int max = 0;
        char result = ' ';

        foreach (char c in input)
        {
            if (freq[c] > max)
            {
                max = freq[c];
                result = c;
            }
        }

        Console.WriteLine($"Most Frequent Character: '{result}'");
    }
}
