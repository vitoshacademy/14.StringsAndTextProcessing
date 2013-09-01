/*Write a program that parses an URL address given in the format:

	and extracts from it the [protocol], [server] and [resource] elements. 
    For example from the URL http://www.vitoshacademy.cloudvps.bg/category/tricks/ the following information should be extracted:
		
* [protocol] = "http"
* [server] = "www.vitoshacademy.cloudvps.bg"
* [resource] = "/category/tricks/"
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void ExtractURL(string url)
    {
        int index = 0;
        index = url.IndexOf(':');
        Console.WriteLine("\n[protocol] = \"{0}\"", url.Substring(0, index));
        url = url.Replace(url.Substring(0, index + 3), "");

        index = url.IndexOf('/');
        Console.WriteLine("[server]   = \"{0}\"", url.Substring(0, index));
        url = url.Replace(url.Substring(0, index), "");

        Console.WriteLine("[resource] = \"{0}\"\n", url);

    }

    static void Main()
    {
        Console.WriteLine("Please, enter a complete url:");
        string url = Console.ReadLine(); ;
        ExtractURL(url);
    }
}
