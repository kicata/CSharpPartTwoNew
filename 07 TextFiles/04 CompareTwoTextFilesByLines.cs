using System;
using System.Collections.Generic;
using System.IO;

//Write a program that compares two text files line by line and prints the number of lines that are the same
//and the number of lines that are different. Assume the files have equal number of lines.

    class CompareTwoTextFilesByLines
    {
        static void Main()
        {
            int equalLinesInFiles = 0;
            int nonEqualLinesInFile = 0;

            string path = @"../../LineOfText.txt";
            List<string> file1 = ReadFileLineByLine(path);

            path = @"../../LineOfText2.txt";
            List<string> file2 = ReadFileLineByLine(path);

            //check are they equals
            for (int i = 0; i < file1.Count; i++)
            {
                if (file1[i].Equals(file2[i]))
                {
                    equalLinesInFiles++;
                }
                else
                {
                    nonEqualLinesInFile++;
                } 
            }
            if (nonEqualLinesInFile==0)
            {
                Console.WriteLine("The two text files are the same");
            }
            else
            {
                Console.WriteLine("The two text files are different :");
                Console.WriteLine("There are {0} Equals rows in two files.", equalLinesInFiles);
                Console.WriteLine("The Different rows are {0} ", nonEqualLinesInFile);
            }
        }
        public static List<string> ReadFileLineByLine(string path)
        { 
            StreamReader reader = new StreamReader(path);
            List<string> linesOfText = new List<string>();
            // storing each line in list
            using (reader)
            {
                string contentLine = "";
                while (contentLine != null)
                {
                    contentLine = reader.ReadLine();
                    if (contentLine == null)
                    {
                        continue;
                    }
                    else
                    {
                        linesOfText.Add(contentLine);
                    }
                }
            }
            return linesOfText;
        }
    }

