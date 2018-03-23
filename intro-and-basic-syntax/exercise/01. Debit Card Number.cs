//CONFIRMED from Yagorundy
using System;

namespace _01._Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //* We receive from the Console 4 numbers
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());

            //* Printing the  debit card numbers in required format -> adding the needed additional digits
            Console.WriteLine($"{num1:d4} {num2:d4} {num3:d4} {num4:d4}");
        }
    }
}
