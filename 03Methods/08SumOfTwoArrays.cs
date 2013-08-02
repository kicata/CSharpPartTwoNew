using System;
using System.Collections.Generic;
using System.Linq;
//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

class SumOfTwoArrays
{
    static void Main()
    {
        Console.WriteLine("Enter first positive integer number = ");
        string firstNumber = Console.ReadLine();
        Console.WriteLine("Enter second positive integer number = ");
        string secondNumber = Console.ReadLine();
        char[] arr1 = firstNumber.ToCharArray();
        Array.Reverse(arr1);
        char[] arr2 = secondNumber.ToCharArray();
        Array.Reverse(arr2);
        AddTwoArray(arr1, arr2);
    }
    public static void AddTwoArray(char[] array1, char[] array2)
    {
        int sum = 0;
        int ostatyk = 0;
        int bigger = Math.Max(array1.Length, array2.Length);
        List<int> result = new List<int>();
        for (int i = 0; i < bigger; i++)
        {
            
            sum = (((array1.Length > i ? int.Parse((array1[i] - 48).ToString()) : 0) + (array2.Length > i ? int.Parse((array2[i] - 48).ToString()) : 0)) + ostatyk) % 10;
            ostatyk = (((array1.Length > i ? int.Parse((array1[i] - 48).ToString()) : 0) + (array2.Length > i ? int.Parse((array2[i] - 48).ToString()) : 0)) + ostatyk) / 10;
            
            result.Add(sum);
        }
        if (ostatyk != 0)
        {
            result.Add(ostatyk);
        }
        result.Reverse();

        foreach (var item in result)
        {
            Console.Write(item);
        }
    }

}