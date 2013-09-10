using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.


class RemoveWordsBetweenTwoFiles
{
    static void Main()
    {
        try
        {
            string path = @"..\..\ExampleToRead12.txt";
            string pathToReadTemplate = @"..\..\ExampleToRead12Patern.txt";
            string pathToWrite = @"..\..\ExampleToRead12Result.txt";
            StreamReader reader = new StreamReader(path);
            string content="";
            using (reader)
            { 
                content = reader.ReadToEnd(); 
                StreamReader patternReader = new StreamReader(pathToReadTemplate);
                StreamWriter writer = new StreamWriter(pathToWrite, false, Encoding.GetEncoding("UTF-8"));
                using (writer)
                {
                    using (patternReader)
                    { 
                        string linePattern = "";
                        while (linePattern != null)
                        {
                            linePattern = patternReader.ReadLine();
                            if (linePattern == null)
                            {
                                break;
                            }
                            string[] pattern = linePattern.Split(' ');
                            for (int i = 0; i < pattern.Length; i++)
                            {
                                string expression=@"\b"+pattern[i]+"\\b";
                                content = Regex.Replace(content, expression, "");
                                content = Regex.Replace(content, @"(\s){2,}", " ");
                            }
                              
                        }
                    }
                    writer.WriteLine(content);
                }
                
            }

        }
        catch (FileNotFoundException fe)
        {
            Console.WriteLine("{0}", fe.Message);
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
