using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that prints to the console which day of the week is today. Use System.DateTime.


    class WhichDayIsToday
    {
        static void Main()
        {
            Console.WriteLine("Today is {0}",DateTime.Now.ToLongDateString());

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
           
            DateTime dateValue = new DateTime(year, month,day);
            Console.WriteLine(dateValue.ToString("dddd"));
        }
    }

