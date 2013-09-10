using System;
using System.Linq;
using System.Text;
//We are given a string containing a list of forbidden
//words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example:
    //Microsoft announced its next generation PHP compiler today. 
    //It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
        //Words: "PHP, CLR, Microsoft"
//The expected result:
//********* announced its next generation *** compiler today.
//It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

    class ReplaceForbiddenWord
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string forbidenWords = "PHP, CLR, Microsoft";
            string[] words = forbidenWords.Split(',');
            for (int i = 0; i < words.Length; i++)
            {
                text = Asterix(text, words[i].TrimStart());
            }
            Console.WriteLine(text);
        }
        static string Asterix(string text, string word)
        {
            int length = word.Length;
            string replacedText = "";
            StringBuilder sb=new StringBuilder();
            for (int i = 0; i < length; i++)
			{
                sb.Append('*');
			}
            string asterixWord = sb.ToString();
            replacedText=text.Replace(word, asterixWord);
            return replacedText;
        }

    }

