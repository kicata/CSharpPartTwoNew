using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
//Find in the array a subset of K elements that have sum S or indicate about its absence.

class SumOfKElementsInNArray
{
    static void Main()
    {
        //enter input
        Console.Write("Enter numbers of element in array N= ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        //fill in array
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter member[{0}]= ",i+1);
            array[i] = int.Parse(Console.ReadLine());

        }
        Console.Write("Enter sum to check Sum= ");
        long sum = long.Parse(Console.ReadLine());
        Console.Write("Enter how many elements to use to get {0} sum K= ",sum);
        int k = int.Parse(Console.ReadLine());

        //begin calulation
        bool isThereSubsetSum = false;
        int combinations = (int)Math.Pow(2, n);

        //start searching
        for (int i = 1; i < combinations; i++)
        {
            long tempSum = 0;
            string result ="";
            int counterOfMembersInUse = 0;

            for (int j = 0; j < array.Length - 1; j++)
            {
                int mask = 1 << j;
                int iAndMask = mask & i;
                int bit = iAndMask >> j;

                if (bit == 1)
                {
                        tempSum += array[j];
                        result = result + " " + array[j];
                        counterOfMembersInUse++;
                }

            }
            //if found what->
            if (tempSum == sum && counterOfMembersInUse==k)
            {
                
                isThereSubsetSum = true;
                Console.WriteLine("Is There Subset Sum from {0} elements equal to {1} -> {2} :",k, sum, isThereSubsetSum);
                Console.WriteLine(result);
                break; 

            }
        }
        //if not found what->
        if (!isThereSubsetSum)
        {
            Console.WriteLine("Is There Subset Sum from {0} elements equal to {1} -> {2}  ", k, sum, isThereSubsetSum);
            
        }
    }
}

