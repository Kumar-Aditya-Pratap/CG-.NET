using System;

class AnagramCheck
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        char[] s1 = Console.ReadLine().ToLower().ToCharArray();

        Console.Write("Enter second string: ");
        char[] s2 = Console.ReadLine().ToLower().ToCharArray();

        if (s1.Length != s2.Length)
        {
            Console.WriteLine("Not Anagrams");
            return;
        }

        Array.Sort(s1);
        Array.Sort(s2);

        Console.WriteLine(new string(s1) == new string(s2)
            ? "Anagrams"
            : "Not Anagrams");
    }
}
