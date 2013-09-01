//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. 
//Format the output aligned right in 15 symbols.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ReadAndPrintANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Decimal:");
            Console.WriteLine("{0,15}", number);
            Console.WriteLine("Hexadecimal:");
            Console.WriteLine("{0,15:X}", number);
            Console.WriteLine("Percentage:");
            Console.WriteLine("{0,15:P}", number);
            Console.WriteLine("Scientific notation:");
            Console.WriteLine("{0,15:E}", number);
            Console.WriteLine();
        }
    }
}
