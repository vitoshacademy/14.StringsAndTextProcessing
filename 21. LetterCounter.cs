// Write a program that reads a string from the console and prints all different letters in the string along with 
// information how many times each letter is found. 


using System;
using System.Collections.Generic;
using System.Linq;

public class LetterCounter
{
    public static void Main()
    {
        Console.WriteLine("Please enter a sentence or two. Then press Enter for the letter count:");
        string[] specialSigns = { " ", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+" };

        string input = Console.ReadLine();

        for (int i = 0; i < specialSigns.Length; i++)
        {
            input = input.Replace(specialSigns[i], string.Empty);
        }

        Dictionary<char, int> allLetters = new Dictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (allLetters.ContainsKey(input[i]))
            {
                allLetters[input[i]]++;
            }
            else
            {
                allLetters.Add(input[i], 1);
            }
        }

        var sortedLetters = allLetters.OrderBy(x => x.Key);
        foreach (var item in sortedLetters)
        {
            Console.WriteLine("Letter --> {0} - Number --> {1}", item.Key, item.Value);
        }
    }
}
