using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a list of words from a file words.txt and finds how many times
//each of the words is contained in another file test.txt. The result should be written in the file result.txt
//and the words should be sorted by the number of their occurrences in descending order. 
//Handle all possible exceptions in your methods.


class CountingWordsBetweenTwoFiles
{
    static void Main()
    {
        try
        {
            string path = @"..\..\test.txt";
            string pathToReadTemplate = @"..\..\words.txt";
            string pathToWrite = @"..\..\result.txt";
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                string content = reader.ReadToEnd();
                string searchItem;
                int count = 0;

                StreamWriter writer = new StreamWriter(pathToWrite, false, Encoding.GetEncoding("UTF-8"));
                using (writer)
                {
                    string[] patternArray = File.ReadAllLines(pathToReadTemplate);

                    string[] result = new string[patternArray.Length - 1];

                    for (int i = 0; i < patternArray.Length - 1; i++)
                    {

                        searchItem = patternArray[i];
                        count = new Regex(searchItem).Matches(content).Count;
                        result[i] = count.ToString() + "-" + searchItem;
                    }
                    Array.Sort(result);
                    Array.Reverse(result);
                    for (int i = 0; i < result.Length; i++)
                    {
                        writer.WriteLine(result[i]);
                        writer.Flush();
                    }

                }
            }
        }
        catch (FileNotFoundException fe)
        {
            Console.WriteLine("{0}",fe.Message);
        }
        catch (DirectoryNotFoundException fe)
        {
            Console.WriteLine("{0}", fe.Message);
        }
        catch (IOException fe)
        {
            Console.WriteLine("{0}", fe.Message);
        }
        
    }

}

