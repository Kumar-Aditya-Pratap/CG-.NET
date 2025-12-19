using System;

class Armstrong
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int input=Convert.ToInt32(Console.ReadLine());
        int original = input;
        int dig;
        int output=0;
        while (input!=0)
        {
            dig = input % 10;
            input = input / 10;
            output = output + (dig*dig*dig);
        }
        if (original==output)
        {
            Console.WriteLine("Number is Armstrong");
            
        }
        else
        {
            Console.WriteLine("not armstrong");
        }

            Console.ReadLine();
    }
}