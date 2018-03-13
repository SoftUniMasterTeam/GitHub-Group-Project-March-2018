using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var curH = int.Parse(Console.ReadLine());
            var maxH = int.Parse(Console.ReadLine());
            var curE = int.Parse(Console.ReadLine());
            var maxE = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |" + new string('|', curH) + new string('.', maxH - curH) + '|');
            Console.WriteLine("Energy: |" + new string('|', curE) + new string('.', maxE - curE) + '|');
        }
    }
}
