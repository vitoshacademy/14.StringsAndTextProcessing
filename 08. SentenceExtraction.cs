/*Write a program that extracts from a given text all sentences containing given word.
	Example: The word is "in". The text is:
We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
So we are drinking all the day. We will move out of it in 5 days.
The expected result is:
We are living in a yellow submarine.
We will move out of it in 5 days
Consider that the sentences are separated by "." and the words – by non-letter symbols*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SentenceExtraction
{
    static void Main()
    {
        Console.WriteLine("Write a small text, without pressing enter. Please use full stops \".\" When you finish the text, press ENTER");
        string sentence = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Input a word from the text above in order to receive all the sentences, in which the word is present");
        string input = Console.ReadLine();
        Console.WriteLine();
        string word = " " + input + " ";
        string wordEnd = " " + input + ".";
        int firstComa = 0;
        int secondComa = sentence.IndexOf(".", firstComa + 1);
        while (secondComa != -1)
        {
            string strSub = sentence.Substring(firstComa, secondComa + 1 - firstComa);

            bool firstWord = false;
            if (firstComa == 0)
            {
                int indexFirstword = sentence.IndexOf(" ");
                string strFirstWord = sentence.Substring(0, indexFirstword + 1);
                if (strFirstWord.IndexOf(word.Trim(), StringComparison.InvariantCultureIgnoreCase) != -1)
                {
                    firstWord = true;
                }
            }
            firstComa = secondComa;

            secondComa = sentence.IndexOf(".", firstComa + 1);
            if (firstComa != 0)
            {
                firstComa += 1;
            }

            if (strSub.IndexOf(word, StringComparison.InvariantCultureIgnoreCase) != -1 || strSub.IndexOf(wordEnd, StringComparison.InvariantCultureIgnoreCase) != -1 || firstWord)
            {
                Console.WriteLine(strSub.Trim());
                firstWord = false;
            }
        }
    }
}

