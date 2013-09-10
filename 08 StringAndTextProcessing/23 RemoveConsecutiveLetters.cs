using System;
using System.Linq;
using System.Text;
//Write a program that reads a string from the console and replaces all series of consecutive identical
//letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

class RemoveConsecutiveLetters
{
    static void Main()
    {
        string inputText = "aaaaaabbbbbssssssddddddHmmmmnnnnnoooppprrr";
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < inputText.Length - 1; i++)
        {
            if (inputText[i] == inputText[i + 1])
            {
                //this is for the last set of letters incase the last letter is the same
                if (i == inputText.Length - 2)
                {
                    sb.Append(inputText[i]);
                }
                else
                {
                    continue;
                }
            }
            else
            {
                sb.Append(inputText[i]);
            }
        }
        Console.WriteLine(sb.ToString());
    }
}

