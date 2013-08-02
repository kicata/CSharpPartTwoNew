using System;
//Write a program that finds the maximal increasing sequence in an array. Example: 
//{3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
class MaxIncrSequenceInArray
{
    static void Main()
    {
        int[] arr = { 3, 2, 3, 4, 5, 4, 6, 8, 4, 10, 1};

            int currentIndex = 0;
            int equalLen = 1;
            int beststartIndex = 0;
            int bestLen = 1;

            for (int i = 0; i < arr.Length - 1; i++)
            {

                if (arr[i] < arr[i + 1])
                {
                    equalLen++;
                }
                else
                {
                    if (equalLen > bestLen)
                    {
                        bestLen = equalLen;
                        equalLen = 1;
                        currentIndex = i;
                        beststartIndex = currentIndex - bestLen + 1;
                        currentIndex = 0;
                    }
                }
            }
            //the last element case/if the sequence is in the end
            int lastLenElement;
            if (equalLen > bestLen)
            {
                bestLen = equalLen;
                lastLenElement = arr[arr.Length - 1];
                Console.WriteLine("maximal sequence of equal elements is {0}", bestLen);
                
                for (int j = beststartIndex + 1; j < beststartIndex + bestLen; j++)
                {
                    Console.Write(arr[j] + ", ");
                }
                Console.Write(lastLenElement);
                Console.WriteLine();
            }
            else
            //here we print the casual situation
            {
                Console.WriteLine("maximal sequence of equal elements is {0}", bestLen);

                for (int j = beststartIndex; j < beststartIndex + bestLen; j++)
                {
                    Console.Write(arr[j] + ", ");
                }
            }   
    }
}

