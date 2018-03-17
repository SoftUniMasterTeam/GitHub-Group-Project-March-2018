using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = int.Parse(Console.ReadLine());
            double energyContentPer100ML = int.Parse(Console.ReadLine());
            double sugarContentPer100ML = int.Parse(Console.ReadLine());

            double kcalAmount = (volume / 100) * energyContentPer100ML;
            double sugarsAmount = (volume / 100) * sugarContentPer100ML;

            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", kcalAmount, sugarsAmount);
        }
    }
}
