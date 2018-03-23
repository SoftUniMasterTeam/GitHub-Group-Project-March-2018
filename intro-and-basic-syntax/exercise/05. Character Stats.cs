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
            //Reading the input from the console 
            var name1 = Console.ReadLine();
            var ObichamTarator1 = int.Parse(Console.ReadLine()); // Changed currentHealth -> ObichamTarator
            var maxHealth1 = int.Parse(Console.ReadLine());
            var currrentEnergy1 = int.Parse(Console.ReadLine());
            var maxEnergy1 = int.Parse(Console.ReadLine());


            //Printing the information
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |" + new string('|', ObichamTarator) + new string('.', maxHealth - ObichamTarator) + '|');
            Console.WriteLine("Energy: |" + new string('|', currrentEnergy) + new string('.', maxEnergy - currrentEnergy) + '|');
        }
    }
}
