using System;
using System.Linq;
//Write a program that reads a list of words,
//separated by spaces and prints the list in an alphabetical order.

class TheEasyTask
{
    static void Main()
    {
        string listOfWords = "This is, the most stuped exercise, ever";
        char[] separator = { ' ', ',' };
        string[] words = listOfWords.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);
        foreach (var item in words)
        {
            Console.WriteLine(item);
        }
    }
}

