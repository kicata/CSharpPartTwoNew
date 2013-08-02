using System;
//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
    class SequenseOfEqualElements
    {
        static void Main()
        {
            int[] arr = { 2, 2, 2, 2, 2, 2, 1, 2, 2, 1 };

            int currentIndex = 0;
            int equalLen = 1;
            int beststartIndex = 0;
            int bestLen = 1;

            for (int i = 0; i < arr.Length-1; i++)
            {

                if (arr[i] == arr[i + 1])
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
                        beststartIndex = currentIndex-bestLen+1;
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

                for (int j = beststartIndex; j < beststartIndex + bestLen-1; j++)
                {
                    Console.Write(arr[j] + ", ");
                }
                Console.Write(lastLenElement);
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

