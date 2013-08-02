using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method that return the maximal element in a portion of array of integers
//starting at given index. Using it write another method that sorts an array in ascending / descending order.


    class MaxElementInAPortion
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 10, 9, 6, 9, 3, 5, 4, 7, 8};
            Console.WriteLine("This is the Array :");
            PrintArray(array);

            Console.Write("enter the starting index to check = ");
            int startIndex = int.Parse(Console.ReadLine());
           
            int answer= FindMax(array, startIndex);
            if (answer==Int32.MinValue)
            {
                Console.WriteLine("Index out of range.Try again ");
            }
            else
            {
                Console.WriteLine(answer);
            }

            Console.WriteLine("Sorted Array in Descending order");
            SortArrayInDescending(array);
            PrintArray(array);
            Console.WriteLine();

            Console.WriteLine("Sorted Array in Ascending order");
            SortArrayInAscending(array);
            PrintArray(array);

            
        }
        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }
        public static int FindMax(int[] arr, int startIndex)
        {
            int max = Int32.MinValue;
            for (int i = startIndex; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static void SortArrayInDescending(int[] array)
        {
            int max = Int32.MinValue;

            for (int i = 0; i < array.Length-1; i++)
            {
                max = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j]>array[max])
                    {
                        max = j;
                    } 
                }
                if (max!=i)
                {
                    //exchange value
                    int k = array[i];
                    array[i] = array[max];
                    array[max] = k;
                }
            }
        }
        public static void SortArrayInAscending(int[] array)
        {
            int min = Int32.MinValue;
            for (int i = 0; i < array.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    //exchange value
                    int k = array[i];
                    array[i] = array[min];
                    array[min] = k;
                }
            }
        }
    }

