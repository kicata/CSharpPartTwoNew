using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array that has a sum S.
//Example:
//	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)


class SubsetSumOfInteger
{
    static void Main()
    {
        Console.Write("Enter sum = ");
        long Sum = long.Parse(Console.ReadLine());
        int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };

        bool isThereSubsetSum = false;
        int combinations = (int)Math.Pow(2, array.Length);

        for (int i = 1; i < combinations; i++)
        {
            long tempSum = 0;
            string result = "";
            for (int j = 0; j < array.Length - 1; j++)
            {
                int mask = 1 << j;
                int iAndMask = mask & i;
                int bit = iAndMask >> j;

                if (bit == 1)
                {
                    tempSum += array[j];
                    result = result + " " + array[j].ToString();

                }

            }

            if (tempSum == Sum)
            {
                isThereSubsetSum = true;
                Console.WriteLine("Is There Subset Sum equal to {0} -> {1} :",Sum, isThereSubsetSum);
                Console.WriteLine(result);
                break;
            }
        }
        if (!isThereSubsetSum)
        {
            Console.WriteLine("Is There Subset Sum equal to {0} -> {1} :", Sum, isThereSubsetSum);
        }
    }  
}

