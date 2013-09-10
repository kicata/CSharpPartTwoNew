using System;
using System.Collections.Generic;
using System.Linq;
//Write a method ReadNumber(int start, int end) that enters an integer number in given range[start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers:
//			a1, a2, … a10, such that 1 < a1 < … < a10 < 100


class ReadNumberInInterval
{
    public static int start;
    public static int end;
    public static List<int> Numbers = new List<int>();

    static void ReadNumber(int start, int end, string number)
    {
        try
        {
            int startNumber = start;
            int endNumber = end;
            int inputNumber = int.Parse(number);
            if (inputNumber > startNumber && endNumber > inputNumber)
            {
                Numbers.Add(inputNumber);
            }
            else
            {
                throw new ArgumentOutOfRangeException("The number is not in range");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("The number is not in correct format");
        }
    }
    static void Main()
    {
        start = 1;
        end = 100;
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter int number in range {0} - {1} = ", start, end);
            string number = Console.ReadLine();
            ReadNumber(start, end, number);
            start = int.Parse(number);
        }
        //Printing the result
        Console.WriteLine("This is the numbers you have entered :");
        Console.Write("1 < ");
        foreach (var item in Numbers)
        {
            Console.Write(item + " < ");
        }
        Console.Write(" 100");
        Console.WriteLine();
    }
}

