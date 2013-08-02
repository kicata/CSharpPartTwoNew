using System;
using System.Linq;

//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).


    class BiggerThanNeighbour
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 3, 3, 7, 9, 3, 2, 7, 4, 8 };
                       
            Console.Write("Enter element position to check his neighbours = ");
            int index = int.Parse(Console.ReadLine());
            if (index > 0 && index < array.Length - 1)
            {
                Console.WriteLine("This is the array: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + ", ");
                }
                Console.WriteLine();

                bool isItBigger=IsBiggerThanNeighbour(array,index);

                Console.WriteLine("The element {0} at index {1} is bigger than his neighbours -> {2}", array[index], index, isItBigger );
            }
            else
            {
                Console.WriteLine("There aren't two neighbours avaliable.Please choose another index");
            }
        }
        public static bool IsBiggerThanNeighbour(int[]array, int index )
        {
           bool isBigger = false;

           if (array[index] > array[index-1] && array[index]>array[index+1] )
           {
               isBigger = true;
           }
           return isBigger;
        }
    }

