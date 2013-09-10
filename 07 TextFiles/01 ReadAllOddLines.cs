using System;
using System.IO;
using System.Linq;
//Write a program that reads a text file and prints on the console its odd lines.

class ReadAllOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../textLines.txt");
        int lineNumber = 1;
        string lineOfText = reader.ReadLine();
        // a little cheat for the first line
        Console.WriteLine(lineOfText);
        using (reader)
        {
            while (lineOfText!=null)
            {
                lineNumber++;
                lineOfText = reader.ReadLine();
                
                if (lineNumber % 2 != 0)
                { 
                    Console.WriteLine(lineOfText);
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}

