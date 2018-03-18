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
            //Reading the input from the console
            string name = Console.ReadLine(); // name of product
            double volume = int.Parse(Console.ReadLine()); //  volume of product
            double energyContentPer100ML = int.Parse(Console.ReadLine()); //energy content per 100ML
            double sugarContentPer100ML = int.Parse(Console.ReadLine());  //sugar content per 100ML

            //Calculating the amount of kcal and sugar
            double kcalAmount = (volume / 100) * energyContentPer100ML; //amount kall
            double sugarsAmount = (volume / 100) * sugarContentPer100ML; //amount sugars

            //Printing the information
            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", kcalAmount, sugarsAmount);
        }
    }
}
