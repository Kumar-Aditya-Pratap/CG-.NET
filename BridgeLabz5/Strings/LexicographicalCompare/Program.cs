using System;

class LexicographicalCompare
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        int len = Math.Min(s1.Length, s2.Length);
        int result = 0;

        for (int i = 0; i < len; i++)
        {
            if (s1[i] != s2[i])
            {
                result = s1[i] - s2[i];
                break;
            }
        }

        if (result == 0)
            result = s1.Length - s2.Length;

        if (result < 0)
            Console.WriteLine($"\"{s1}\" comes before \"{s2}\"");
        else if (result > 0)
            Console.WriteLine($"\"{s2}\" comes before \"{s1}\"");
        else
            Console.WriteLine("Both strings are equal");
    }
}
