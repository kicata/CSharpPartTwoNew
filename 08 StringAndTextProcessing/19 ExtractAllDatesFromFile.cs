using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Globalization;
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.
namespace _19_ExtractAllDatesFromFile
{
    class ExtractAllDatesFromFile
    {
        static void Main()
        {
            string text = "22.12.2008,text text text text text text text vtext text text text" +
                        "text texttexttexttexttext text text text 25.10.2096 . Tdadasdad sdasdadae" +
                        "asdaddefrrsdvcvbgfbbdd 27.08.2000 dfljsldkfl sdfkslj ntelijds,fsi rrejri abv@abv.bg.";
            string data = text;
            string format = "dd.MM.yyyy";
            string temp = "";
            //instantiate with this pattern 
            Regex date = new Regex(@"\b\d{2}.\d{2}.\d{4}\b");
            MatchCollection dateMatches = date.Matches(data);

            StringBuilder sb = new StringBuilder();

            foreach (Match dataMatch in dateMatches)
            {
                //collecting
                sb.AppendLine(dataMatch.Value);
                //converting
                temp = dataMatch.Value.ToString();
                DateTime dateForPrint = DateTime.ParseExact(temp,format, CultureInfo.InvariantCulture);
                //printing
                Console.WriteLine(dateForPrint.ToString("f",
                          CultureInfo.CreateSpecificCulture("en-CA")));
            }
            Console.WriteLine(sb.ToString()); 
        }
    }
}
