using System;

class Q1
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the fibonacci series");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 0, b = 1;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i=2;i<n;i++) 
        {
            int next = a + b;
            
            
            Console.WriteLine(next);
            a = b;
            b = next;
        }
        Console.ReadLine();
    }
}