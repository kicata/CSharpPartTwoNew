using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

class BracketsCheck
{
    static void Main()
    {
        Console.Write("Enter expression = ");
        string expression = Console.ReadLine();
        int counterOpenBracket = 0;
        int counterCloseBracket = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            char currentChar = expression[i];
            if (currentChar == ')')
            {
                if (i == 0)
                {
                    Console.WriteLine("Wrong bracked in expression ");
                    return;
                }
                else if (i > 0 && expression[i - 1] == '(')
                {
                    Console.WriteLine("Wrong bracked in expression ");
                    return;
                }
                counterCloseBracket++;
            }
            else if (currentChar == '(')
            {
                if (i == expression.Length - 1)
                {
                    Console.WriteLine("Wrong bracked in expression ");
                    return;
                }
                else if (i > 0 && expression[i - 1] == ')')
                {
                    Console.WriteLine("Wrong bracked in expression ");
                    return;
                }
                counterOpenBracket++;
            }
        }
        if (counterOpenBracket != counterCloseBracket)
        {
            Console.WriteLine("Wrong bracked in expression: Expression is invalid ");
            return;
        }
        Console.WriteLine("Expression and barackets are okay");
    }
}

