using System;
using System.IO;
using System.Text;
//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

class ReadAndPrintFromFile
{
   
    public static void Main()
    {
        try
        {
            
           // string path="";
            string path = @"..\..\introScreen.txt";
            // Open the file to read from. 
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid (for example, it is on an unmapped drive).");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file specified in path was not found");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("path is null"); 
        }
        catch (ArgumentException)
        {
            Console.WriteLine("path is a zero-length string, contains only white space, or contains\none or"+
                              "more invalid characters as defined by InvalidPathChars.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file. ");
        }
    }
}

