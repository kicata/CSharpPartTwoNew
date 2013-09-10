using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GreedyDwarf
{
   public static void Main()
    {
        string vally = Console.ReadLine();
        int[] val = ReturnIntArray(vally);
        int m = int.Parse(Console.ReadLine());
        string[] patternCont = new string[m];
        //input
        for (int i = 0; i < m; i++)
        {
            patternCont[i] = Console.ReadLine();
        }
        long bestCoinSum = long.MinValue; 
        string pattern = String.Empty;
        //here we go
        for (int i = 0; i < patternCont.Length; i++)
        {
            pattern = patternCont[i];//single pattern
            long coinSum = ReturnCoinSum(pattern,val);
            
            if (coinSum > bestCoinSum)
            {
                bestCoinSum = coinSum;
            }
            //Console.WriteLine(coinSum);
        }
       Console.WriteLine(bestCoinSum);
    }
    static long ReturnCoinSum(string pattern, int[] val )
    {
        bool [] isVisited=new bool[val.Length];
        int[] pattrn = ReturnIntArray(pattern);
        long coinSum = val[0];
        isVisited[0] = true;
        int currentPos=0;
        int addStep = 0;
        int position = 0;
        int nextPosition = 0;
        //pass pattern
        while (currentPos<val.Length && currentPos>=0)
        {
           
            
            
            for (int j = 0; j < pattrn.Length; j++)
            {
                addStep = pattrn[j];
                nextPosition = position + addStep;
                
                if ((nextPosition > 0 && nextPosition < val.Length) && (!isVisited[nextPosition]))//outside of array
                {
                    coinSum = coinSum + val[nextPosition];
                    isVisited[nextPosition] = true;
                    position = nextPosition;
                }
                else
                {
                    return coinSum;
                }
                
            }
           
        }
        return 0;
    }
    static int[] ReturnIntArray(string input)
    {
        char[] sep = { ',', ' ' };
        string[] strArr = input.Split(sep, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[strArr.Length];
        for (int i = 0; i < strArr.Length; i++)
        {
            array[i] = int.Parse(strArr[i]);
        }
        return array;
    }
}

