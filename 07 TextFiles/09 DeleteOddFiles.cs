using System;
using System.IO;
using System.Text;
//Write a program that deletes from given text file all odd lines. The result should be in the same file.
class DeleteOddFiles
{
    static void Main()
    {
        try
        {
            string fileName = @"../../Lorem ipsum.txt";
            string tempFileName = @"../../newFile.txt";
            StreamReader reader = new StreamReader(fileName);
            using (reader)
            {
                // Write new file
                int lineNumber = 0;
                StreamWriter writer = new StreamWriter(tempFileName, false, Encoding.GetEncoding("utf-8"));
                using (writer)
                {
                    // Read lines
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lineNumber++;
                        if (lineNumber % 2 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            File.Delete(fileName);
            File.Move(tempFileName, fileName);
        }
        catch (FileNotFoundException fe)
        {
            Console.WriteLine("{0}", fe.Message);
        }     
   
    }
}

