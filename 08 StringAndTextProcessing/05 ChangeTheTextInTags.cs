using System;
using System.Linq;
using System.Text;
//You are given a text. Write a program that changes the text in all regions surrounded
//by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 

class ChangeTheTextInTags
{
    static void Main(string[] args)
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else except<upcase>green submarine</upcase>.";
        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '<')
            {
                i += 8;
                while (text[i] != '<')
                {
                    builder.Append(text[i].ToString().ToUpper());
                    i++;
                }
                i += 8;//to escape the "</upcase>"
            }
            else
            {
                builder.Append(text[i]);
            }
        }
        Console.WriteLine(builder.ToString());
    }
}



