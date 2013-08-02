using System;
using System.Linq;
//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.



    class IsBiggerThanNeighbourIndex
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6,10, 9 };

                Console.WriteLine("This is the array: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + ", ");
                }
                Console.WriteLine();
                
                for (int i = 1; i < array.Length-1; i++)
                {
                    bool isItBigger = IsBiggerThanNeighbour(array, i);
                    if (isItBigger)
                    {
                        Console.WriteLine("The first element that is bigger than his neighbours  is {0} at index {1} ", array[i], i);
                        return;
                    }
                }
                Console.WriteLine("-1");
                Console.WriteLine("There isn't such element in array"); 
        }
        public static bool IsBiggerThanNeighbour(int[] array, int index)
        {
            bool isBigger = false;

            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                isBigger = true;
            }
            return isBigger;
        }
    }

