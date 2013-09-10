using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings. Sample input:
//Hi!
//Expected output:
//\u0048\u0069\u0021
class StringToUnicodeLiteral
{
    static void Main()
    {
        Console.WriteLine("Enter a string ");
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();
        ushort sign;
        foreach (var ch in arr)
        {
            sign=ch;
            Console.Write("\\u{0:x4}",sign);
        }
        Console.WriteLine();
    }
}

