using System;
using System.Linq;
using System.Threading;
using System.Globalization;
//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

class MultipleTaskProgram
{
    static void Main()
    {
        Console.WriteLine("Hello, this is a multiple task program.\nPlease choose what to do:\n");
        Console.WriteLine("\"Reverses the digits of a number\" - Enter 1\n");
        Console.WriteLine("\"Calculates the average of a sequence of integers\" - Enter 2\n");
        Console.WriteLine("\"Solves a linear equation a * x + b = 0\"- Enter 3\n");
        Console.Write("Please choose : ");
        string userChoise = Console.ReadLine();
        int userNum;
        //checking the user input
        if (int.TryParse(userChoise, out userNum))
        {
            if (userNum > 0 && userNum < 4)
            {
                switch (userNum)
                {
                    case 1: ReverseDigits(); break;
                    case 2: AverageOfSequence(); break;
                    case 3: SolvesLinearEquation(); break;
                    default: Console.WriteLine("WTF");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You must enter a int number between 1 - 3. Try again.");
                return;
            }
        }
        else
        {
            Console.WriteLine("You must enter a int number. Try again.");
            return;
        }
        

    }
    public static void AverageOfSequence()
    {
        //input average number
        int number;
        do
        {
            Console.WriteLine("Enter how many members in sequence you want to use = ");
            number = int.Parse(Console.ReadLine());
        } while (number < 1);

        int[] arr = new int[number];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter member {0} = ", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("This is the sequence you have entered: ");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        double average = arr.Average();
        Console.WriteLine("The average of the sequence is {0}", average);

    }
    public static void ReverseDigits()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter a decimal number to reverse ");
        decimal decNumber = decimal.Parse(Console.ReadLine());
        //check the input
        if (decNumber < 0)
        {
            Console.WriteLine("The number must be positive.Try again");
            return;
        }
        else
        {
            string decNumberToString = decNumber.ToString();
            char[] arr = decNumberToString.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine("This is the reversed number:");
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
    public static void SolvesLinearEquation()
    {
        //check the input
        int a;
        do
        {
            Console.Write("Enter a = ");
            a = int.Parse(Console.ReadLine());
        } while (a==0);
        Console.Write("Enter b= ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("The Linear equation to solve is: ");
        Console.WriteLine("{0}*x + {1} = 0",a,b);
        Console.WriteLine("The answer is x = {0}",-b/a);

    }
}

