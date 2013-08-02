using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them
//using the method GetMax().


    class GetMaxMethod
    {
        static void Main()
        {
            Console.Write("Enter first int number = ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter second int number = ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("Enter third int number = ");
            int third = int.Parse(Console.ReadLine());

            int temp = GetMax(first, second);
            temp = GetMax(temp, third);
            Console.WriteLine("The maximum int number is {0}", temp);
        }
        static int GetMax(int first,int second)
        {
            int firstArg = first;
            int secondArg = second;
            int bigger = firstArg;
            if (bigger<secondArg)
            {
                bigger = secondArg;
                return bigger;
            }
            else
            {
                return bigger;
            }
        }
    }

