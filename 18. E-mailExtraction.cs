/* Write a program for extracting all email addresses from given text. 
 * All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EmailExtraction
{
    static void Main()
    {
        string str = "A @telerik.com. This baj.ivan@yahoo.co.uk. This is also: ISTRUEexa_mple@abv.bg ";
        int atIndex = 0;
        int startIndex = 0;
        int firstDotIndex = 0;
        int lastDotIndex = 0;
        int endIndex = 0;

        bool at = false;
        bool letterBeforeAt = false;
        bool letterAfterAt = false;
        bool dotAfterAtAfterLetter = false;
        bool letterAfterDot = false;
        bool ident = false;
        bool domain = false;

        for (int i = 0; i < str.Length - 5; i++)
        {
            if (str.Substring(i, 1) == "@")
            {
                at = true;
                atIndex = i;
                if (char.IsLetter(str[i - 1]))
                {
                    startIndex = str.LastIndexOf(" ", atIndex) + 1;
                    letterBeforeAt = true;
                }
                if (char.IsLetter(str[i + 1]))
                {
                    letterAfterAt = true;
                }

                endIndex = str.IndexOf(" ", atIndex);

                for (int k = atIndex + 2; k < endIndex; k++)
                {
                    if (str.Substring(k, 1) == ".")
                    {
                        dotAfterAtAfterLetter = true;
                        firstDotIndex = k;
                        if (char.IsLetter(str[firstDotIndex + 1]))
                        {
                            letterAfterDot = true;
                        }
                    }

                }
                lastDotIndex = str.LastIndexOf(".", atIndex);
                if (char.IsLetter(str[lastDotIndex + 1]))
                {
                    domain = true;

                }

                if (atIndex - startIndex > 6)
                {
                    ident = true;
                }
                if (endIndex - lastDotIndex > 3)
                {
                    domain = true;
                }

            }
            if (at && letterBeforeAt && letterAfterAt &&
                dotAfterAtAfterLetter && letterAfterDot && ident && domain)
            {
                int length = endIndex - startIndex;
                Console.WriteLine(str.Substring(startIndex, length));

                at = false;
                letterBeforeAt = false;
                letterAfterAt = false;
                dotAfterAtAfterLetter = false;
                letterAfterDot = false;
                ident = false;
                domain = false;
            }
        }
    }
}
