using System;
//Write a program that compares two char arrays lexicographically (letter by letter).

class CompareTwoArraysLexicographically
{
    static void Main(string[] args)
    {
        char[] arr1 = { 'z', 'o', 'o' };
        char[] arr2 = { 'z', 'o', 'o', 'l', 'o', 'o' };


        if (arr1.Length > arr2.Length)
        {
            for (int index = 0; index < arr2.Length; index++)
            {
                if (arr1[index] > arr2[index])
                {
                    Console.WriteLine("arr2 is infront of arr1");
                    break;
                }
                else if (arr1[index] < arr2[index])
                {
                    Console.WriteLine("arr1 is infront of arr2");
                    break;
                }
                else
                {
                    if ((arr1[index] == arr2[index]) && (index == arr2.Length - 1))
                    {
                        Console.WriteLine("arr2 is infront of arr1");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        else if (arr1.Length < arr2.Length)
        {
            for (int index = 0; index < arr1.Length; index++)
            {
                if (arr1[index] > arr2[index])
                {
                    Console.WriteLine("arr2 is infront of arr1");
                    break;
                }
                else if (arr1[index] < arr2[index])
                {
                    Console.WriteLine("arr1 is infront of arr2");
                    break;
                }
                else
                {
                    if ((arr1[index] == arr2[index]) && (index == arr1.Length - 1))
                    {
                        Console.WriteLine("arr1 is infront of arr2");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        else
        {
            for (int index = 0; index < arr1.Length; index++)
            {
                if (arr1[index] > arr2[index])
                {
                    Console.WriteLine("arr2 is infront of arr1");
                    break;
                }
                else if (arr1[index] < arr2[index])
                {
                    Console.WriteLine("arr1 is infront of arr2");
                    break;
                }
                else
                {
                    if ((arr1[index] == arr2[index]) && (index == arr1.Length - 1))
                    {
                        Console.WriteLine("The two arrays are equal");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}
