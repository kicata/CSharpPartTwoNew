using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace _10_ConsoleJustification
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRows = int.Parse(Console.ReadLine());
            int MaxtRowLength = int.Parse(Console.ReadLine());
            StringBuilder sb =new StringBuilder ();
            char[]sep={' '};
            string[] container=new string[numRows];
            string input = String.Empty;
            string temp = String.Empty;

            for (int i = 0; i < numRows; i++)
            {
                input = Console.ReadLine();
                temp = Regex.Replace(input, @"\s+", " ").Trim();
                sb.Append(temp);
                sb.Append(' ');
            }
            temp = sb.ToString();
            string[] words = temp.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            int currentRowLength = 0;
            int nextRowLength;// = currentRowLength+wordLen;
            int wordLen=0;
            int countUsedWordOnWord = 0;
            List<int> spaceIndex = new List<int>();
            //Console.Write(new string('.', outerDots));
            
            StringBuilder rOut = new StringBuilder();
            for (int i = 0; i <words.Length; i++)
            {
                temp = words[i];
                wordLen = temp.Length;
                nextRowLength = currentRowLength + wordLen;
                int diffrnce=0;
                //endIndex=currentRowLength
                if (nextRowLength>MaxtRowLength)
                {
                    if (currentRowLength>MaxtRowLength)
                    { 
                        Console.WriteLine(rOut.ToString());//print sentence
                        currentRowLength = 0;
                        nextRowLength = 0;
                        countUsedWordOnWord = 0;
                        spaceIndex.Clear();
                        rOut.Clear();//clear and append last word.
                        rOut.Append(temp);
                        rOut.Append(' ');
                        currentRowLength = wordLen + 1;
                        spaceIndex.Add(currentRowLength);
                        countUsedWordOnWord++;
                        
                    }
                    else if (currentRowLength < MaxtRowLength)
                    {
                        diffrnce = MaxtRowLength-currentRowLength;
                        int numOfSpaceOnRow = countUsedWordOnWord - 1;
                        rOut.Remove(currentRowLength - 1, 1);//remove last white space
                        //spaceIndex.RemoveAt(numOfSpaceOnRow);
                        //numOfSpaceOnRow--;
                        diffrnce++;
                        
                        while (diffrnce > 0)
                        {
                            int count = 0;
                            for (int j = 0; j < numOfSpaceOnRow; j++)
                            {
                                rOut.Insert(spaceIndex[j] + count,' ');
                                count++;
                                diffrnce--;
                                if (diffrnce<1)
                                {
                                    break;
                                }
                            }
                        }
                        Console.WriteLine(rOut.ToString());//print sentence
                        currentRowLength = 0;
                        nextRowLength = 0;
                        countUsedWordOnWord = 0;
                        spaceIndex.Clear();
                        rOut.Clear();//clear and append last word.
                        rOut.Append(temp);
                        rOut.Append(' ');
                        currentRowLength = wordLen + 1;
                        spaceIndex.Add(currentRowLength);
                        countUsedWordOnWord++;
                    }
                    else
                    {//currentRowLength=MaxRow.Length
                        rOut.Remove(currentRowLength - 1, 1);
                        diffrnce = 1;
                        
                        int numOfSpaceOnRow = countUsedWordOnWord - 1;
                        while (diffrnce > 0)
                        {
                            int count = 0;
                            for (int j = 0; j < numOfSpaceOnRow; j++)
                            {
                                rOut.Insert(spaceIndex[j] + count, ' ');
                                count++;
                                diffrnce--;
                                if (diffrnce < 1)
                                {
                                    break;
                                }
                            }
                        }
                        Console.WriteLine(rOut.ToString());//print sentence
                        currentRowLength = 0;
                        nextRowLength = 0;
                        countUsedWordOnWord = 0;
                        spaceIndex.Clear();
                        rOut.Clear();//clear and append last word.
                        rOut.Append(temp);
                        rOut.Append(' ');
                        currentRowLength = wordLen + 1;
                        spaceIndex.Add(currentRowLength);
                        countUsedWordOnWord++;
                    }
                    if (i==words.Length-1)
                    {
                        Console.WriteLine(rOut.ToString());
                    }
                }
                else
                {
                    rOut.Append(temp);
                    rOut.Append(' ');
                    currentRowLength = nextRowLength + 1;//add 1 for interval
                    spaceIndex.Add(currentRowLength);
                    countUsedWordOnWord++;
                }
                
            }
        }
    }
}
