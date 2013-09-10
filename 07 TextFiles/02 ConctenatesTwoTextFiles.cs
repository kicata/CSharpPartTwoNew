using System;
using System.IO;
using System.Linq;
using System.Text;
//Write a program that concatenates two text files into another text file.
class ConctenatesTwoTextFiles
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../textLines.txt");
        string firstPart = "";
        string secondPart = "";
        //read first file
        using (reader)
        {
            firstPart = reader.ReadToEnd();
        }
        Console.WriteLine("This is the first file: ");
        Console.WriteLine(firstPart);
        reader = new StreamReader(@"../../secondTextFile.txt");
        //read second file
        using (reader)
        {
            secondPart = reader.ReadToEnd();
        }
        Console.WriteLine("This is the second file: ");
        Console.WriteLine(secondPart);
        string result = string.Concat(firstPart, secondPart);
        Console.WriteLine("And this is the result that will be writen in a new file : ");
        Console.WriteLine(result);
        //write a new file
        StreamWriter writer = new StreamWriter(@"../../concatenatedFile.txt", false, Encoding.GetEncoding("utf-8"));
        using (writer)
        {
            writer.Write(result);
            writer.Flush();
        }
        Console.WriteLine("Check the project folder the file must be there");
    }
}

