using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
//Modify the solution of the previous problem to replace only whole words (not substrings).
class ReplaceAWholeWord
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../restart.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter(@"../../finishWholeWord.txt", false, Encoding.GetEncoding("utf-8"));
            string line = "";
            string pattern = @"\brestart\b";
            string replace = "finish";
            string result = "";
            using (writer)
            {
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    result = Regex.Replace(line, pattern, replace);
                    writer.WriteLine(result);
                }
            }
            Console.WriteLine("Check the new file in solution folder");
        }
    }
}

