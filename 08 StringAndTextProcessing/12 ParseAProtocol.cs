using System;
using System.Linq;
using System.Text;
//Write a program that parses an URL address given in the format:
        //[protocol]://[server]/[resource]
//and extracts from it the [protocol], [server] and [resource] elements. For example
//from the URL http://www.devbg.org/forum/index.php the following information
//should be extracted:
//[protocol] = "http"
//[server] = "www.devbg.org"
//[resource] = "/forum/index.php"


    class ParseAProtocol
    {
        static void Main()
        {
            string url = @"http://dnes.dir.bg/news/simeon-saxkoburggotski-izbori-2013-14810263?nt=4";
            char[] separators = { '/', ':' };
            string[] arr = url.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            OutputFormat(arr);
         }
        static void OutputFormat(string[] arr)
        {
            
            string [] formatedOutput = new string[3];
            formatedOutput[0] = "[protocol] = " + "\"" + arr[0] + "\"";
            formatedOutput[1] = "[server] = " + "\"" + arr[1] + "\"";
            StringBuilder sb = new StringBuilder();
            char slash='\\';
            for (int i = 2; i < arr.Length; i++)
            {
                sb.Append(slash);
                sb.Append(arr[i]);
            }
            formatedOutput[2] = "[resource] = " + "\"" + sb.ToString() + "\"";
            foreach (var item in formatedOutput)
            {
                Console.WriteLine(item);
            }
        }
    }

