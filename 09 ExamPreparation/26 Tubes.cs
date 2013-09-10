using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            int tubes = int.Parse(Console.ReadLine());
            long friends =long.Parse(Console.ReadLine());
            long [] tubesLen=new long[tubes];

            for (int i = 0; i < tubesLen.Length; i++)
            {
                tubesLen[i] = long.Parse(Console.ReadLine());

            }
            long maxTubeLength = 0;
            for (int i = 0; i < tubesLen.Length; i++)
            {
                if (tubesLen[i]>maxTubeLength)
                {
                    maxTubeLength = tubesLen[i];
                }
            }
            
            //for (long i = maxTubeLength; i >= 1; i--)
            //{
            //    long bestLen = 0;
            //    for (int j = 0; j < tubesLen.Length; j++)
            //    {
            //        bestLen += tubesLen[j] / i;
            //    }
            //    if (bestLen>=friends)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }

            //}
            long left = 1;
            long right = maxTubeLength;
            long middle = (right - left) / 2;
            long finalResult = -1;

            while (left <= right)
            {

                long bestCut = 0;
                for (int j = 0; j < tubesLen.Length; j++)
                {
                    bestCut += tubesLen[j]/ middle;
                    
                }
                Console.WriteLine(bestCut);
                if (bestCut < friends)
                {
                    right = middle - 1;
                }
                else if (bestCut >= friends)
                {
                    left = middle + 1;
                    finalResult = middle;
                }

                middle = (right + left) / 2;
            }
            Console.WriteLine(finalResult);
        }
    }

