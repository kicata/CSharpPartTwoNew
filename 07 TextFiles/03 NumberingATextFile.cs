using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

    class NumberingATextFile
    {
        static void Main()
        {
            string path = @"../../LineOfText.txt";
            StreamReader reader= new StreamReader(path);
            int lineCounter=0;
            List<string> linesOfText = new List<string>();
            //calculating how many line of text we have in the file and storing each line in list
            using (reader)
            {
                string contentLine = "";
                while (contentLine != null)
                {
                    contentLine = reader.ReadLine();
                    if (contentLine==null)
                    {
                        continue; 
                    }
                    else
                    {
                        lineCounter++;
                        linesOfText.Add(contentLine);
                    }
                }
            }
            
           string pathToWrite = @"../../NumberedLineOfText.txt";
           StreamWriter writer = new StreamWriter(pathToWrite, false, Encoding.GetEncoding("utf-8"));
           string numberedLineOfText = "";
           using (writer)
           {
               for (int i = 0; i < lineCounter; i++)
               {
                   numberedLineOfText= i+1 +" "+ linesOfText[i];
                   writer.WriteLine(numberedLineOfText);
               }
               writer.Flush();
           }
        }
    }

