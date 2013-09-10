using System;
using System.Collections.Generic;
using System.Linq;
//Write a program that reads a string from the console and prints all different words
//in the string along with information how many times each word is found. 

class CountingLetterOccuranceInText
{
    static void Main()
    {
        string text = "The result string is affected by by the formatting information is of a specific DateTimeFormatInfo object.";
        char[] separator = { ' ', ',', '.', '!', '?' };
        Dictionary<string, int> diction = new Dictionary<string, int>();

        string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            if (diction.ContainsKey(words[i]))
            {
                diction[words[i]] += 1;
            }
            else
            {
                diction.Add(words[i], 1);
            }
        }
        foreach (var item in diction)
        {
            Console.WriteLine("Word \"{0}\" count \"{1}\"", item.Key, item.Value);
        }
    }
}