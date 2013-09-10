using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

class ReverseWordInSentence
    {
        static void Main()
        {
            string inputSentence = "C# is not C++, not PHP and not Delphi!";
            char[] separator = { ' ',',','!' };
            List<char> letterAndSign = new List<char>();
            for (char i = 'a'; i <= 'z'; i++)
            {
                letterAndSign.Add(i);
            } 
            for (char i = 'A'; i <= 'Z'; i++)
            {
                letterAndSign.Add(i);
            } 
            for (char i = '0'; i <= '9'; i++)
            {
                letterAndSign.Add(i);
            } 
            letterAndSign.Add('@'); letterAndSign.Add('#'); letterAndSign.Add('$');
            letterAndSign.Add('%'); letterAndSign.Add('&'); letterAndSign.Add('&');
            letterAndSign.Add('*'); letterAndSign.Add('+'); letterAndSign.Add('-');
            letterAndSign.Add('^'); letterAndSign.Add('~');
            //split sentence by sign
            string[] words = inputSentence.Split(separator,StringSplitOptions.RemoveEmptyEntries);
           
            //split sentence by letters 
            string[] symbols=inputSentence.Split(letterAndSign.ToArray(),StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();
            Array.Reverse(words);

            for (int i = 0; i < symbols.Length; i++)
            {
                sb.Append(words[i]);
                sb.Append(symbols[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }

