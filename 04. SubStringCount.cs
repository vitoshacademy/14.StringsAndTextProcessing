/*Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
 * Example: The target substring is "in". The text is as follows:
 * 
 * We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. 
 * So we are drinking all the day. We will move out of it in 5 days.

	The result is: 9.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubstringCount
{
    static void Main()
    {
        Console.WriteLine("Enter some text:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter a string to search for:");
        string word = Console.ReadLine();

        int count = 0;

        for (int i = 0; i < text.Length - word.Length + 1; i++)
        {
            if (string.Compare(text.Substring(i, word.Length), word, true) == 0)
            {
                count++;
            }
        }
        if (count == 1)
        {
            Console.WriteLine("The string \"{0}\" is repeated once.", word);            
        }
        else if (count == 0)
        {
           Console.WriteLine("The string \"{0}\" is not found in the text", word);            
        }
        else
        {
            Console.WriteLine("The string \"{0}\" is repeated {1} times.", word, count);            
        }

    }
}

