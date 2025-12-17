using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_of_handshakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of persons: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int handshakes = (n * (n - 1)) / 2;
            Console.WriteLine("The total number of handshakes will be:" + handshakes);
        }
    }
}