using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t----------CALCULATOR----------");
            Console.WriteLine("Enter the first number: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What operations you would like to perform?\n press 1 for addition\n press 2 for substraction\n" +
                " press 3 for multiplication\n press 4 for division");
            int user_input = Convert.ToInt32(Console.ReadLine());
            if (user_input==1) {
                Console.WriteLine("Sum of the numbers is "+ (first+second));
            }
            else if (user_input==2) {
                Console.WriteLine("Difference of the numbers is "+ (first-second));
            }
            else if (user_input == 3)
            {
                Console.WriteLine("Product of the numbers is " + (first * second));
            }
            else if (user_input == 4)
            {
                Console.WriteLine("Quotient of the numbers is " + (first / second));
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
