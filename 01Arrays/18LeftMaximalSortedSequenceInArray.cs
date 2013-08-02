using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads an array of integers and removes from it a minimal number
//of elements in such way that the remaining array is sorted in increasing order.
//Print the remaining sorted array. Example:
//	{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

    class LeftMaximalSortedSequenceInArray
    {
        static void Main()
        {
            //input data

            Console.Write("Enter number of elements N = ");
            int numOfElements = int.Parse(Console.ReadLine());
            long []array=new long [numOfElements];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter arrayMember {0} = ",i+1);
                array[i] = long.Parse(Console.ReadLine());
            }

            //long [] array = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
           
            int combinations = (int) Math.Pow(2,array.Length);
            int lengthSequence=0;
            int bestLengthSequence=0;

            List<long> MaximalSortedSequence=new List<long>();

            //searching for maximal sorted sequence
            for (int i = 1; i < combinations; i++)
            {
                //list for every combination
                List<long> tempList=new List<long>();

                for (int j = 0; j < array.Length; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = mask & i;
                    int bit = iAndMask >> j;

                    if (bit == 1)
                    {
                        tempList.Add(array[j]);
                        lengthSequence++;
                    }
                }

                if (IsSorted(tempList))
	            {
                    if (lengthSequence > bestLengthSequence)
	                {
		                bestLengthSequence=lengthSequence;

                        MaximalSortedSequence=tempList;
	                }   
                }
                lengthSequence = 0;
            }
            //Prnt the result

            Console.WriteLine("The remaining array sorted in increasing order is: ");
            foreach (var item in MaximalSortedSequence)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();
       
        }  

        static bool IsSorted(List<long> tempList)
        {
            bool isSorted = true;
            for (int i = 0; i < tempList.Count-1; i++)
			{
			    if (!(tempList[i]<=tempList[i+1]))
	            {
		         isSorted=false; 
	            }
			}
            return isSorted;

        }
    
}

