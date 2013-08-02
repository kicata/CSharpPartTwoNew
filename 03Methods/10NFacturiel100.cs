using System;
using System.Linq;
using System.Numerics;
//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 



    class NFacturiel100
    {
        static void Main()
        {
            for (int i = 0; i <= 100; i++)
            {
                BigInteger facturiel = Facturiel(i);
                Console.WriteLine("{0}!={1}",i ,facturiel);
            }     
        }
        public static BigInteger Facturiel(int n)
        {
            //bootom of recursion
            if (n==0)
            {
                return 1;
            }
            //recursion
            else
            {
                return n * Facturiel(n - 1);
            }
        }
    }

