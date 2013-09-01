/* Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:
Enter the first date: 27.02.2006
Enter the second date: 3.03.2004
Days between: 4 days */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class DatesCalculator
{
    static void Main()
    {
        string format = "dd.MM.yyyy";

        Console.WriteLine("Enter date in format - dd.MM.yyyy");
        string DateOne = Console.ReadLine();
        DateTime dateOne = DateTime.ParseExact(DateOne, format, CultureInfo.InvariantCulture);

        string DateTwo = Console.ReadLine();
        DateTime dateTwo = DateTime.ParseExact(DateTwo, format, CultureInfo.InvariantCulture);

        Console.WriteLine("The different between {0} and {1} is {2}.", dateOne, dateTwo, ((dateTwo - dateOne).TotalDays));
    }
}
