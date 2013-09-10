using System;
using System.Linq;

    class ValidateHTML
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] code = new string[n];
            for (int i = 0; i < n; i++)
            {
                code[i] = Console.ReadLine();
            }
            int openTagCount = 0;
            int closeTagCount = 0;
            string line=String.Empty;

            for (int i = 0; i < code.Length; i++)
            {
                line = code[i].Trim();
                for (int j = 0; j < line.Length-1; j++)
                {
                    if (line[j]=='<')
                    {
                        if (line[j+1]=='/')
                        {
                            closeTagCount++;
                        }
                        else
                        {
                            openTagCount++;
                        }
                    }  
                }
                if (openTagCount == closeTagCount)
                {
                    Console.WriteLine("VALID");
                }
                else
                {
                    Console.WriteLine("INVALID");
                }
                openTagCount = 0;
                closeTagCount = 0;
            }
            
        }
    }

