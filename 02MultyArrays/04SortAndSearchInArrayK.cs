using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
 

    class SortAndSearchInArrayK
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            int[] array= new int[n];
            
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Enter member [{0}] = ",i+1);
                    array[i] = int.Parse(Console.ReadLine());
                }
           
            Console.Write("Enter k = ");
            int k = int.Parse(Console.ReadLine());

            Array.Sort(array);
            int minValue=array.Min();
            int maxValue=array.Max();
            int result=0;
            int indexOfElement=Array.BinarySearch(array, k);

            //if isNotFoundDirectly

            if (indexOfElement < 0)
            {
                indexOfElement *=-1;
                result = indexOfElement - 2;
                if (result < 0)
                {
                    Console.WriteLine("Invalid Output.The value of K is smaller than Array.MinValue...Try again");
                    return;
                }
            }
            Console.WriteLine("The element of array that is <=K \\{0}\\ is {1}",k, array[result]);
        } 

    }

