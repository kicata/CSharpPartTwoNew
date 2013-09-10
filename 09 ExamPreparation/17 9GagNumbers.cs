using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] GagNum = { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };
            List<int> indexedInput = new List<int>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i]);
                if (sb.Length>=2)
                { 
                    for (int j = 0; j < GagNum.Length; j++)
                    {
                        if (sb.ToString().Equals(GagNum[j]))
                        {
                            int currentIndex = j;
                            indexedInput.Add(currentIndex);
                            sb.Clear();
                            break;
                        }
                    }
                }
            }
            decimal sum = 0;
            decimal power = 1;
            for (int i = indexedInput.Count - 1; i >= 0; i--)
            {
                sum = sum + indexedInput[i] * power;
                power*=9;
            }
            Console.WriteLine(sum);
        }
    }

