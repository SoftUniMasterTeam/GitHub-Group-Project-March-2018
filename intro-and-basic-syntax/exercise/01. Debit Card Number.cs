// CONFIRMED from DKitov
using System;

namespace _01._Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //* We receive from the Console 4 numbers
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            //* Printing the  debit card numbers in required format -> adding the needed additional digits
            Console.WriteLine($"{num1:d4} {num2:d4} {num3:d4} {num4:d4}");
        }
    }
}
