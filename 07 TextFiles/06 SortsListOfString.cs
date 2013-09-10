using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
//Write a program that reads a text file containing a list of strings, sorts them and saves them 
//to another text file. Example:
//Ivan			George
//Peter			Ivan
//Maria			Maria
//George		Peter

class SortsListOfString
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../ListOfNames.txt");
        List<string> names = new List<string>();

        using (reader)
        {
            //reading from file and fill in list
            string line = "";
            while (line != null)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                names.Add(line);
            }
            //print for view
            Console.WriteLine("this is list before sorting");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            names.Sort();
            Console.WriteLine();
            Console.WriteLine("this is list after sorting");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            //writing in new file
            StreamWriter writer = new StreamWriter(@"../../SortedListOfNames.txt", false, Encoding.GetEncoding("utf-8"));
            using (writer)
            {
                for (int i = 0; i < names.Count; i++)
                {
                    writer.WriteLine(names[i]);
                }
                writer.Flush();
            }
        }
        //send user a message
        Console.WriteLine("The sorted file must be in solution folder");
    }
}

