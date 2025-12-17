using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the numbers are :" + (a + b));
            Console.WriteLine(a+b);
            
            

        }
    }
}
