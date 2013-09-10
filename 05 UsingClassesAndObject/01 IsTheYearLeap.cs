using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.


    class IsTheYearLeap
    {
        static void Main()
        {
            Console.Write("Enter a year = ");
            int year = int.Parse(Console.ReadLine());

            bool isLeap =  DateTime.IsLeapYear(year);
            Console.WriteLine(" Is the year {0} leap -> {1}", year, isLeap);
        }
    }

