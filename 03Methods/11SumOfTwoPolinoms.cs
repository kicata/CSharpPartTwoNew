using System;
using System.Linq;
//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5 501


class SumOfTwoPolinoms
{
    static void Main()
    {
        decimal[] firstPolinom = { 5, 8, };
        Console.Write("First polinom :");
        PrintPolinoms(firstPolinom);
        decimal[] secondPolinom = { 7, 2, 6 };
        Console.Write("Second polinom :");
        PrintPolinoms(secondPolinom);
        int longerLength = firstPolinom.Length;
        if (firstPolinom.Length<secondPolinom.Length)
        {
            longerLength = secondPolinom.Length;
        }
        decimal[] result = new decimal[longerLength];
        SumPolinoms(firstPolinom, secondPolinom, result);
        PrintPolinoms(result);
    }

    public static void SumPolinoms(decimal[] firstPolinom, decimal [] secondPolinom, decimal [] result)
    { 
        int minLength=0;
        int whitchIsShorter = 0;
        if (firstPolinom.Length<secondPolinom.Length)
        {
            minLength = firstPolinom.Length;
            whitchIsShorter=1;
        }
        else
        {
            minLength = secondPolinom.Length;
            whitchIsShorter = 2;
        }
        for (int i = 0; i < minLength; i++)
        {
            result[i] = firstPolinom[i] + secondPolinom[i];
        }
        for (int i = minLength; i < result.Length; i++)
        {
            if (whitchIsShorter==1)
            {
                result[i] = secondPolinom[i];
            }
            else
            {
                result[i] = firstPolinom[i];
            }
        }
    }
    public static void PrintPolinoms(decimal[] polinom)
    {
        for (int i = polinom.Length - 1; i >= 0; i--)
        {
            if (polinom[i] != 0 && i != 0)
            {
                if (polinom[i - 1] >= 0)
                {
                    Console.Write("{0}x^{1} + ", polinom[i], i);
                }
                else
                {
                    //if polinom [i]<0
                    Console.Write("{0}x^{1} ",  polinom[i], i);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polinom[i]);
            }
        }

        Console.WriteLine();
    }
}