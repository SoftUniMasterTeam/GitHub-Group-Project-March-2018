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
            var name = Console.ReadLine();
            var ObichamTarator = int.Parse(Console.ReadLine()); // Changed currentHealth -> ObichamTarator
            var maxHealth = int.Parse(Console.ReadLine());
            var currrentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());


            //Printing the information
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |" + new string('|', ObichamTarator) + new string('.', maxHealth - ObichamTarator) + '|');
            Console.WriteLine("Energy: |" + new string('|', currrentEnergy) + new string('.', maxEnergy - currrentEnergy) + '|');
        }
    }
}
