using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

    class ReverseAString
    {
        static void Main()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("The Reverse string is: ");
            Console.WriteLine(ReverseString(input));

        }
        public static string ReverseString(string s)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                builder.Append(s[i]);
            }
            return builder.ToString();
        }
    }

