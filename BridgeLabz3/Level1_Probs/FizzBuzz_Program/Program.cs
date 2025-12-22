using System;

class FizzBuzz_Program
{
    static void Main()
    {
        Console.WriteLine("Enter a Integer: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (n > 0)
        {
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                
                arr[i] = i;
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 3 == 0 && arr[i]!=0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (arr[i] % 5 == 0 && arr[i] != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (arr[i] % 5 == 0 && arr[i]%3==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(arr[i]);
                }
            }



        }
    }
}