using System;
using System.Linq;
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.


class MinMaxAverageSumProductMethod
{
    static int number;
    static void Main()
    {
        //user input
        Console.Write("Enter how many int numbers you want to calculate ");
        number = int.Parse(Console.ReadLine());
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter member {0} = ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        //result
        Console.WriteLine("The Min Value in sequence is: ");
        MinValue(array);
        Console.WriteLine();
        Console.WriteLine("The Max Value in sequence is: ");
        MaxValue(array);
        Console.WriteLine();
        Console.WriteLine("The average of the sequence is: ");
        Average(array);
        Console.WriteLine();
        Console.WriteLine("The sum of the sequence is: ");
        Sum(array);
        Console.WriteLine();
        Console.WriteLine("The product of the sequence is: ");
        Product(array);
        Console.WriteLine();

    }
    public static void MinValue(params int[] array)
    {
        int minValue = array.Min();
        Console.WriteLine(minValue);
    }
    public static void MaxValue(params int[] array)
    {
        int maxValue = array.Max();
        Console.WriteLine(maxValue);
    }
    public static void Average(params int[] array)
    {
        double average = array.Average();
        Console.WriteLine(average);
    }
    public static void Sum(params int[] array)
    {
        int sum = array.Sum();
        Console.WriteLine(sum);
    }
    public static void Product(params int[] array)
    {
        int product = 1;
        foreach (var item in array)
        {
            product = product * item;
        }
        Console.WriteLine(product);
    }

}

