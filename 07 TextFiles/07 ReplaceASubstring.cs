using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;
//Write a program that replaces all occurrences of the substring "start" with the substring "finish"
//in a text file. Ensure it will work with large files (e.g. 100 MB).

    class ReplaceASubstring
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"../../restart.txt");
            using (reader)
            {
                string content = reader.ReadToEnd();
                StringBuilder text = new StringBuilder(content);
                Console.WriteLine("This is the read file:");
                Console.WriteLine(text);
                Console.WriteLine();
                Console.WriteLine();

                text.Replace("start", "finish");
                Console.WriteLine("This is the repalced file:");
                Console.WriteLine(text);
                Console.WriteLine();
                //write in a new file
                StreamWriter writer = new StreamWriter(@"../../refinish.txt", false, Encoding.GetEncoding("utf-8"));
                using (writer)
                {
                    writer.Write(text);
                    writer.Flush();
                }
                Console.WriteLine("Check the new file in solution folder");
            }
        }
    }

