using System;
using System.Linq;
//Write a program that reads two arrays from the console and compares them element by element.

class CompareTwoArrays
{
    static void Main()
    {
        //Reading and initializing
        Console.Write("Enter Array1 Length = ");
        int Array1Length = int.Parse(Console.ReadLine());
        int[] Array1 = new int[Array1Length];

        for (int i = 0; i < Array1Length; i++)
        {
            Console.Write("Enter Array1 member {0} = ",i+1);
            Array1[i] = int.Parse(Console.ReadLine());
            
        }
        Console.WriteLine();
        Console.Write("Enter Array2 Length = ");
        int Array2Length = int.Parse(Console.ReadLine());

        int[] Array2 = new int[Array2Length];

        for (int i = 0; i < Array2Length; i++)
        {
            Console.Write("Enter Array2 member {0} = ", i + 1);
            Array2[i] = int.Parse(Console.ReadLine());

        }
        Console.WriteLine();

        int MinLength = Array1Length;
        if (Array1Length>Array2Length)
        {
            MinLength = Array2Length;
        }
        //Compare
        for (int i = 0; i < MinLength; i++)
        {
            if (Array1[i]>Array2[i])
            {
                Console.WriteLine("Array1 is in front of Array2"); 
            }
            else if (Array1[i] > Array2[i])
            {
                Console.WriteLine("Array2 is in front of Array1"); 
            }
            else
            {
                continue;
            }
        }
        if (Array1Length<Array2Length)
        {
            Console.WriteLine("Array1 is in front of Array2");
        }
        else if (Array1Length > Array2Length)
        {
            Console.WriteLine("Array2 is in front of Array1");
        }
        else
        {
            Console.WriteLine("The two arrays are equal");
        }
    }
}

