﻿using System;

using System.Linq;
//Write a program that allocates array of 20 integers and initializes each element by
//its index multiplied by 5. Print the obtained array on the console.




    class ArrayOf20Integers
    {
        static void Main()
        {
            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write( array[i]+" ");
            }
            Console.WriteLine();
        }
    }

