using System;
//Write a method that asks the user for his name and prints “Hello, <name>”
//(for example, “Hello, Peter!”). Write a program to test this method.


    class PrintNameMethod
    {
        static void Main()
        {
            string personName = AskName();
            Console.WriteLine("Hello, "+ personName);
        }
        static string AskName()
        {
            Console.Write("What is your name ");
            string name = Console.ReadLine();
            return name;
        }
    }

