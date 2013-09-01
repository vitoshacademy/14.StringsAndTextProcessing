// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
// Display them in the standard date format for Canada.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        string format = "dd.MM.yyyy";

        string text = "some text and some date line 10.01.2015 and some more. text and 05.03.2051"
            + "some more mails line 22.12.2012 end of the world 2k.12.2012";

        foreach (var extracted in Regex.Matches(text, @"\d{2}.\d{2}.\d{4}"))
        {

            string extractedToString = Convert.ToString(extracted);

            DateTime date = DateTime.ParseExact(extractedToString, format, CultureInfo.InvariantCulture);

            Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
        }
    }
}
