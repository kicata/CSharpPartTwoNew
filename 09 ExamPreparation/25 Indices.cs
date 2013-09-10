using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Indices
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split(' ');
            int[] arrayOfNum = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                arrayOfNum[i] = int.Parse(array[i]);
            }
            bool[] visited = new bool[n];
            int currIndex = 0;
            int loopStart=-1;
            StringBuilder result = new StringBuilder();
            while (true)
            {
                
                if (currIndex<0 || currIndex>=n)
                {
                    break;
                }
                if (visited[currIndex])   
                {
                    loopStart = currIndex;
                    break;
                }

                result.Append(currIndex);
                result.Append(' ');

                visited[currIndex] = true;
                currIndex = arrayOfNum[currIndex];
                
            }
            if (loopStart>=0)
            {
                int index=result.ToString().IndexOf(( " " + loopStart + " ").ToString());
                if (index<0)
                {
                    result.Insert(0, '(');
                }
                else
                {
                    result[index] = '(';
                }

                result[result.Length-1]=')';

            }

            Console.WriteLine(result.ToString().Trim());

        }
    }

