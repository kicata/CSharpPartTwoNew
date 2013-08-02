using System;
//Sorting an array means to arrange its elements in increasing order.
//Write a program to sort an array. Use the "arr: Find the smallest element,
//move it at the first position, find the smallest from the rest, move it at the second position, etc.


class SortingArray
{
    static void Main()
    {
        int[] arr = { 2, 68, 34, 56, 789, 123, 45, 67, 890, 234 };
       
        Console.WriteLine("This is unsorted array:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0}, ", arr[i]);
        }
        Console.WriteLine();
        int min = Int32.MinValue;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            min=i;
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            if (min != i)
            {
                int k = arr[i];
                arr[i] = arr[min];
                arr[min] = k;
            } 
        }
        Console.WriteLine("This is sorted array:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0}, ",arr[i]);
        }
        
    }
}

