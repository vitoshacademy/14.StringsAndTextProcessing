// Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
// Hi!
// Expected output:
// \u0048\u0069\u0021


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringToSequence
{
    static void Main()
    {
        Console.WriteLine("Please, enter a word to be converted to Unicode character literals:");
        string str = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("The conversion of the word {0} is the following:",str);
        Console.WriteLine();
        foreach (var symbol in str)
        {
            Console.Write("\\u{0:X4} ", (int)symbol);
        }
        Console.WriteLine();

    }
}
