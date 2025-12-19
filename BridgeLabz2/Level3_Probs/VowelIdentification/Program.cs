using System;

class VowelIdentification
{
    static void Main()
    {
        Console.WriteLine("Enter the String:");
        string a = Console.ReadLine();
        string b = "";
        int count = 0;
        for(int i = 0; i < a.Length; i++)
        {
            if (a[i]== 'a' || a[i] == 'e'|| a[i] == 'i'|| a[i] == 'o'|| a[i] == 'u')
            {
                b += a[i];
                count += 1;
            }
        }
        Console.WriteLine(b);
        Console.WriteLine(count);
        Console.ReadLine();
    }
}