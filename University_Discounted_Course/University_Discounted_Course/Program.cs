using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Discounted_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the price of the course that the university is offering: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the discount in % provided by the univerity: ");
            double discount = Convert.ToDouble(Console.ReadLine());
            double discounted_amount = ((discount/100)*price);
            double discounted_price = (price-discounted_amount);
            Console.WriteLine($"The price of the course offered by the university is : {price}.\nThe discount offered is {discount}%.\nThe discounted amount is {discounted_amount} and the discounted price is {discounted_price} ");
        }
    }
}
