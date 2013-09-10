using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:
//.NET – platform for applications from Microsoft
//CLR – managed execution environment for .NET
//namespace – hierarchical organization of classes

    class ParseTextAsDictionary
    {
        static void Main()
        {
            string text = ".NET – platform for applications from Microsoft.\nCLR – managed execution environment for .NET.\nnamespace – hierarchical organization of classes";
            string[] splitDict = text.Split('–', '\n');
            Console.WriteLine("Write a word to translate: ");
            string inputWord = Console.ReadLine();
            string temp = "";
            bool isFound = false;
            for (int i = 0; i < splitDict.Length; i++)
            {
                temp = splitDict[i].Trim();
                if (temp.Equals(inputWord))
                {
                    Console.WriteLine("{0}-{1}",splitDict[i],splitDict[i+1]);
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Sorry the word is missing in dictionary"); 
            }
            //THE EASY WAY;
            //Hashtable sampleTable = new Hashtable();
            //sampleTable.Add(".NET", "platform for applications from Microsoft");
            //sampleTable.Add("CLR", "managed execution environment for .NET");
            //sampleTable.Add("namespace", "hierarchical organization of classes");
            //Console.WriteLine("Write a word to translate: ");
            //string inputWord = Console.ReadLine();
            //if (sampleTable.ContainsKey(inputWord))
            //{
            //    Console.WriteLine(sampleTable[inputWord]);  
            //}
            //else
            //{
            //    Console.WriteLine("Word not found in dictionary");
            //}
        }
    }

