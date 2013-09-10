using System;
using System.Linq;
using System.Threading;
using System.Globalization;
//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2004
//Distance: 4 days

    class CalculateDaysBetweenDates
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture=CultureInfo.InvariantCulture;
            string format="dd.MM.yyyy";
            Console.WriteLine("Enter first date in format dd.MM.yyyy :");
            string firstDate=Console.ReadLine();
            Console.WriteLine("Enter second date in format dd.MM.yyyy :");
            string secondDate=Console.ReadLine();

            DateTime date1 = DateTime.ParseExact(firstDate, format, CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(secondDate, format, CultureInfo.InvariantCulture);
            TimeSpan t = date1 - date2;
            double numberOfDays = t.TotalDays;

            if (numberOfDays<0)
            {
                numberOfDays *= -1;
            }
            Console.WriteLine("Distance:{0} days",numberOfDays);
        }
    }

