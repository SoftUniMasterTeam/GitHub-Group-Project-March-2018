using System;

namespace MilesToKilometers
{
    class Program   // Program that converts miles to kilometres
    {
        static void Main(string[] args)
        {
            // Read from console
            double miles = double.Parse(Console.ReadLine());

            double kilometers = miles * 1.60934;    // convert miles to kilometres
            Console.WriteLine($"{kilometers:f2}");  // print result
        }
    }
}
