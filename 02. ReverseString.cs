//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample" to "elpmas".


using System;

class StringAndTextProcessing
{
    static void Main()
    {
        Console.WriteLine("Enter something!");
        string something = Console.ReadLine();
        char[] reversed = something.ToCharArray();
        Array.Reverse(reversed);
        reversed.ToString();
        Console.WriteLine(reversed);
    }
}

