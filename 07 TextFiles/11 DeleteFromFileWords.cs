using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//Write a program that deletes from a text file all words that start with the prefix "test".
//Words contain only the symbols 0...9, a...z, A…Z, _.

class DeleteFromFileWords
{
    static void Main()
    {
        try
        {
            string path = @"..\..\testPrefixExample.txt";
            string pathToWrite = @"..\..\testPrefixExampleReady.txt";
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                string line = "";
                StreamWriter writer = new StreamWriter(pathToWrite);
                using (writer)
                {
                    while (line != null)
                    {
                        line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        line=Regex.Replace(line, @"\btest[a-zA-Z0-9_\s]*","");
                        writer.WriteLine(line);
                    }
                }
            }

        }
        catch (FileNotFoundException fe)
        {
            Console.WriteLine("the input file is missing {0}",fe.Message); 
        }
        catch (DirectoryNotFoundException fe)
        {
            Console.WriteLine("{0}", fe.Message);
        }
    }
}
