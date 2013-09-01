/*You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
The tags cannot be nested. Example:

We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
		The expected result:
We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class UppercaseTask
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        char[] textArray = text.ToCharArray();
        int index = 0;

        while ((index = text.IndexOf("<upcase>", index)) != -1)
        {
            index += 8;

            while (textArray[index] != '<')
            {
                textArray[index] = Char.ToUpper(textArray[index]);
                index++;
            }
        }

        text = new string(textArray);
        text = text.Replace("<upcase>", "").Replace("</upcase>", "");

        Console.WriteLine(text);
    }
}
