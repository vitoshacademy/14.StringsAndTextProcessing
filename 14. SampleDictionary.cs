/* A dictionary is stored as a sequence of text lines containing words and their explanations. 
Write a program that enters a word and translates it by using the dictionary. 
 
Sample dictionary:
.NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.SampleDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dictionary = { ".NET - platform for applications from Microsoft",
                                "CLR - managed execution environment for .NET",
                                "namespace - hierarchical - organization of classes",
                              "Java - object-oriented programming language, similar to C#",
                              "Javascript - web programming language"};
            Console.WriteLine("Please, write one of the following:\n.NET\nCLR\nnamespace\nJava\nJavascript\n");
            string word = Console.ReadLine();
            foreach (string line in dictionary)
            {
                if (line.IndexOf(word + " -") == 0)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
