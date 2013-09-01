// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. 
// Example: "aaaaabbbbbcdddeeeedssaa" => "abcdedsa".


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Write something like \"aaaabbb\" to see how it is transformed to \"ab\" ");
		Console.Write("Text: ");
		string content = Console.ReadLine();
		string removedConsecutives = RemoveConsecutiveLetters(content);
		Console.WriteLine("No consecutives text:");
		Console.WriteLine(removedConsecutives);
	}

	private static string RemoveConsecutiveLetters(string content)
	{
		var result = new StringBuilder();
		result.Append(content[0]);
		for (int i = 1; i < content.Length; i++)
		{
			if (content[i] != result[result.Length - 1])
			{
				result.Append(content[i]);
			}
		}
		return result.ToString();
	}
}

