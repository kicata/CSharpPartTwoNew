//Question: Describe the strings in C#. 
//Answer: Strings are collections of characters. 
//A string is a class that holds characters and provides operations such as 
//subscripting, concatenation, and comparison that we usually associate with the notion of a "string."

//Question: What is typical for the string data type? 
//Answer: A string type allows us to manipulate character data through methods and properties.

//Question: Describe the most important methods of the String class.
//Answer:  * Split -isolate and extract substrings with a single function call.
//* IndexOf, IndexOfAny, LastIndexOf, LastIndexOfAny - search index
//* Contains - same as IndexOf but return true or false
//* CopyTo, String.Copy - copy string
//* string.Concat - to append strings; string.Join - to append strings with char 
//* Insert -  insert a string at any position in an existing string.
//* Remove = remove a series of characters starting at any position. 
//* Replace - Replace loops over a string and changes all instances of one pattern to another. It does not stop after a single replacement.
//* Length - length of string
//* Substring 
//* Compare, Equals, StringComparer, StringComparison
//* Format
//* TryParse, DateTime.Parse, Enum.Parse, int.Parse, int.TryParse, Hex Format
//* ToUpper, ToLower
//* Trim, TrimEnd, TrimStart,
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WhatIsStringInCSharp
{
    static void Main()
    {
        string value = "dot";
        value += "net";
        string result = string.Concat(value, "perls");
        Console.WriteLine(result);
    }
}

