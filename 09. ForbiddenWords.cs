/*We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks. Example:

  Microsoft announced its next generation PHP compiler today. 
  It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
		Words: "PHP, CLR, Microsoft"
		The expected result:
  ********* announced its next generation *** compiler today. 
  It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("Write a text, containing the words \"PHP\", \"Microsoft\" or \"CLR\" to see these words changed to \"*\".");
        string textInput = Console.ReadLine();
        string[] forbiddenWords = "PHP, CLR, Microsoft".Split(',');
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            forbiddenWords[i] = forbiddenWords[i].Trim();
            textInput = textInput.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }

        Console.WriteLine(textInput);
    }
}
