using System;
using System.Linq;
using System.Text;
//Write a program that reads a string from the console and prints all different letters
//in the string along with information how many times each letter is found. 

class CountingLetterOccuranceInText
{
    static void Main()
    {
        string text = "The result string is affected by the formatting information of a specific DateTimeFormatInfo object.";
        char[] separator = { ' ', ',', '.', '!', '?' };
        string letter = "";
        int index = 0;
        int strLen = 0;
        int count = 0;
        int result=0;
        string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        //from words to letters
        StringBuilder sb = new StringBuilder();
        foreach (var item in words)
        {
            sb.Append(item);
        }
        char[] letters = sb.ToString().ToCharArray();
        //uncoment if you use a dictionary
        //Dictionary<char, int> diction = new Dictionary<char, int>();

        //searching
        strLen = letters.Length;
        int currentLen = strLen;//used for narrowing the search area;
        StringBuilder container = new StringBuilder();
        int checkIfUsed=0;
        for (int i = 0; i < strLen; i++)
        {
            //with dictionary easy and clean
            //if you want to see uncomment and comment other things

            //if (diction.ContainsKey(letters[i]))
            //{
            //    diction[letters[i]] += 1;
            //}
            //else
            //{
            //    diction.Add(letters[i], 1);
            //}

            //this is without dictionary 
            letter = letters[i].ToString();
            for (int j = 0; j < currentLen; j++)
            {
                result = text.IndexOf(letter, index,currentLen-index);
                if (result != -1)
                {
                    index = result + 1;
                    count++;
                }
                else
                {
                    break;
                }
            }

            checkIfUsed=container.ToString().IndexOf(letter);//check if already used
            if (checkIfUsed==-1)
            {
                container.Append(letter);
                Console.WriteLine("Letter {0} count in text {1}", letter, count);//Print result in console
                //set everything to zero for the next search
                count = 0;
                result = 0;
                index = 0;
                currentLen = strLen;
            }
            else
            {
                continue;
            }
        }
        //uncomment if you use a dictionary;
        //foreach (var item in diction)
        //{
        //    Console.WriteLine("Letter \"{0}\" count \"{1}\"", item.Key, item.Value);
        //}

    }
}

