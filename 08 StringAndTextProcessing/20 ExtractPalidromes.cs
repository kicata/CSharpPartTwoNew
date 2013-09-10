using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

class ExtractPalidromes
{
    static void Main()
    {
        string text = "ABBA, texttxet, exe apa text text vtext text text text" +
                        "text texttexttexttexttext text text text 25.10.2096. Tdadasdad sdasdadae" +
                        "asdaddefrrsdvcvbgfbbdd 27.08.2000 ABBA, texttxet, exe apa dfljsldkfl sdfkslj ntelijds,fsi rrejri abv@abv.bg.";
        char[] separator = { ' ', ',', '.', '?' };
        string[] seprText = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        bool isPalidrom = false;
        List<string> palidromes = new List<string>();
        int len; int middle; int min; int max;
        string temp = "";
        for (int i = 0; i < seprText.Length; i++)
        {
            temp = seprText[i];
            len = temp.Length;
            middle = len / 2;
            min = 0;
            max = temp.Length - 1;
            for (int j = 0; j < middle; j++)
            { 
                if (temp[min]==temp[max])
                {
                    min++;
                    max--;
                   isPalidrom=true;
                }
                else
                {
                    isPalidrom = false;
                    break;
                }
            }
            if (isPalidrom)
            {
                palidromes.Add(temp);
            }
        }
        Console.WriteLine("The palidrom words in text are:  ");
        foreach (var item in palidromes)
        {
            Console.WriteLine(item);
        }
    }
}

