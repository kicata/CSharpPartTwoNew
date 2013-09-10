using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

    class ExtractAllEmailAddress
    {
        static void Main()
        {
            string text = "dytrada@gmail.com,text text text text text text text vtext text text text"+
                        "text texttexttexttexttext text text text email@yahoo.com . Tdadasdad sdasdadae"+
                        "asdaddefrrsdvcvbgfbbdd fdklsfoweif dfljsldkfl sdfkslj ntelijds,fsi rrejri abv@abv.bg.";
            string data = text; 
            //instantiate with this pattern 
            Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
                RegexOptions.IgnoreCase);

            //find items that matches with our pattern
            MatchCollection emailMatches = emailRegex.Matches(data);
            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);
            }
            Console.WriteLine(sb.ToString());
        }
    }

