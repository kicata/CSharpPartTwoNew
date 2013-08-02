using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading;
//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). 
//Use generic method (read in Internet about generic methods in C#).


class GenericMethods
    {
        
        static void Main()
        {
            
            Console.WriteLine("The Min Value in sequence is: {0:F2}", MinValue(1.0, 3.0, 9.0));
            Console.WriteLine();
            Console.WriteLine("The Max Value in sequence is: {0:F2}",MaxValue(1.0, 3.0, 9.0, 4658));
            Console.WriteLine();
            Console.WriteLine("The average of the sequence is: {0:0}",Average(7,8,9));
            Console.WriteLine();
            Console.WriteLine("The sum of the sequence is: {0}", Sum(1,2,3,5,6,8,9));
            Console.WriteLine();
            Console.WriteLine("The product of the sequence is: {0}",Product(2,3,5));
            Console.WriteLine();

        }
        public static T MinValue<T>(params T[] array)
        {
            dynamic minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (minValue>array[i])
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }
        public static T MaxValue<T>(params T[] array)
        {
            dynamic maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
        public static T Average<T>(params T[] array)
        {
            dynamic sum = Sum(array);
            dynamic average = sum / array.Length;
            return average;
        }
        public static T Sum<T>(params T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i<array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }
        public static T Product<T>(params T[] array)
        {
            dynamic product = 1;
            foreach (var item in array)
            {
                product = product * item;
            }
            return product;
        }
    }

