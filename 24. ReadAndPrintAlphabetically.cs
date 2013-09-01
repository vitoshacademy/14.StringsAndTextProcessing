//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.


using System;
using System.Linq;

public class AlpabeticalOrder
{
    public static void Main()
    {
        Console.WriteLine("Please, enter some text here:\n");
        string[] inWords = Console.ReadLine().Split();
        Console.WriteLine("This is the alphabetical order of the text:\n");
        var sortedWords = inWords.OrderBy(x => x);
        foreach (var item in sortedWords)
        {
            Console.WriteLine("{0} ", item);
        }
        Console.WriteLine();
    }
}
