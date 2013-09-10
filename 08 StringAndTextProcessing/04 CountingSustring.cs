using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
//Write a program that finds how many times a substring is contained in a 
//given text (perform case insensitive search).

    class CountingSustring
    {
        static void Main()
        {
            string text = "We are living in an yellow submarine. We don't have anything else."+
            "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string substrToCheck = @"in";

            int numberOfContain = Regex.Matches(text, substrToCheck, RegexOptions.IgnoreCase).Count;
            Console.WriteLine("{0}",numberOfContain);
        }
    }