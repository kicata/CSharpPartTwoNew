using System;
using System.Text;
//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?
class MaxSumSequenceInArray
{
    static void Main()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int maxSum = 0;
        int currentSum = 0;
        //int pos = 0;
        //int posEnd = 0;
        StringBuilder bestSequenceBuild = new StringBuilder();
        string bestSequnce = "";

        for (int i = 0; i < arr.Length; i++)
        { 
            currentSum += arr[i];
            bestSequenceBuild.AppendFormat("{0}, ", arr[i]);
           // Console.WriteLine("this is current sum={0}", currentSum);

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                //pos = i;
                //Console.WriteLine(pos);
                //Console.WriteLine("this is max sum={0}",maxSum);
                bestSequnce = bestSequenceBuild.ToString();
            }
            if (currentSum < 0)
            {
                //posEnd = i;
                //Console.WriteLine("end{0}",posEnd);
                currentSum = 0;
                bestSequenceBuild.Clear();
            }
        }

        //Console.WriteLine("the maxSum is {0} ", maxSum);
        //for (int i = pos; i <= posEnd; i++)
        //{
        //    Console.Write("{0},  ", arr[i]);
        //}
        Console.WriteLine("The best sequence is: \" {0} \" ", bestSequnce);
        Console.WriteLine("The best sum is: {0} ", maxSum);
    }
}

