using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Write a program that reads from the console a string of maximum 20 characters.
//If the length of the string is less than 20, the rest of the characters should
//be filled with '*'. Print the result string into the console.

    class StringOf20Chars
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder();
            Console.WriteLine("Write a string ");
            string input = Console.ReadLine();
            int inputLength=input.Length;
            if (inputLength>20)
	        {
                string twentyChars = input.Substring(0, 20);
                Console.WriteLine(twentyChars);
	        }
            else if (inputLength<20)
            {
                int difference = 20 - inputLength;
                builder.Append(input);
                for (int i = 0; i < difference; i++)
                {
                    builder.Append('*');
                }
                Console.WriteLine(builder.ToString());
                Console.WriteLine(builder.ToString().Count());
            }
            else
            {
                Console.WriteLine(input);
                Console.WriteLine(input.Length);
            }
        }
    }

