// Write a program that reads from the console a string of maximum 20 characters. 
// If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
// Print the result string into the console.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StringReaderAndExchanger
{
    static void Main()
    {
        Console.WriteLine("Please enter string with exactly 20 characters. If you enter less, the program will fill up the rest with *.");
        string text = Console.ReadLine();

        if (text.Length > 20)
        {
            Console.WriteLine("You have added more than 20 characters. Please try again!");
            Main();
        }
        else
        {
            StringBuilder twentyChars = new StringBuilder();
            twentyChars.Append(text);
            while (twentyChars.Length < 20)
            {
                twentyChars.Append('*');
            }
            Console.WriteLine("The changed text is:{0}", twentyChars.ToString());
        }
    }
}


