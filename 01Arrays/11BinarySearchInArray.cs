using System;
//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).



class BinarySearchInArray
{
    static void Main()
    {
        int[] array = { 1, 3, 5, 7, 9, 44, 2, 68, 6, 8, 85 };

        Console.WriteLine("This is the array- choose a member to search its index");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine();
        //sort
        Array.Sort(array);
        Console.WriteLine("This is the array after sort");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }
        //input
        Console.Write("Enter Member to search = ");
        int member = int.Parse(Console.ReadLine());
        bool isFound = false;
        int min = 0;
        int max = array.Length - 1;
       //search....
        while (max >= min)
        {
            int middle = (min + max) / 2;

            if (array[middle] < member)
            {
                min = middle + 1;
            }
            else if (array[middle] > member)
            {
                max = middle - 1;
            }
            else if (array[middle] == member)
            {
                isFound = true;
                Console.WriteLine("The index of this element is {0}", middle);
                break;
            }
            
        }
        //if not found
        if (!isFound)
        {
            Console.WriteLine("There is Not such element in array ");
        }
            
    }

}


