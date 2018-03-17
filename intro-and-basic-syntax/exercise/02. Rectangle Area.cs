// CONFIRMED from DKitov
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            // * Reading from Console rectangle sides in double format
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            // * Calculating the rectangle area and printing the area formatted to the second digit after the decimal point 
            Console.WriteLine("{0:F2}", a * b);
        }
    }
}
