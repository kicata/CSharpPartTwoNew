using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method that calculates the number of workdays between today and given date, 
//passed as parameter. Consider that workdays are all days from Monday to Friday except 
//a fixed list of public holidays specified preliminary as array.


class NumberOfWorkDaysBetween
{
    static void Main()
    {
        Console.Write("Enter date YYYY/MM/DD separate by \"/\" to calculate the working days: ");
        //split the input to array
        string[] givenDate = Console.ReadLine().Split('/');
        int day = int.Parse(givenDate[2]);
        int month = int.Parse(givenDate[1]);
        int year = int.Parse(givenDate[0]);

        DateTime endDate = new DateTime(year, month, day);
        DateTime startDate = DateTime.Today;
        //save for later use
        DateTime saveStartDateForPrint = startDate;

        int periodLength = Math.Abs((endDate - startDate).Days);
        //Holiday array if someone wants to add another dates
        DateTime[] holidays =
            {
                new DateTime(2013,1,1),
                new DateTime(2013,3,3),
                new DateTime(2013,5,1),
                new DateTime(2013,5,6),
                new DateTime(2013,9,22),
                new DateTime(2013,9,6),
                new DateTime(2013,12,31),
            };
        //if something stupid entered
        if (startDate > endDate)
        {
            Console.WriteLine("The date you entered must be bigger than current day.TRY AGAIN ");
            return;
        }
        //calculating work days
        int workDays = 0;
        for (int i = 0; i < periodLength; i++)
        {
            //adding a day to current date
            startDate = startDate.AddDays(1);
            if (startDate.DayOfWeek != DayOfWeek.Sunday && startDate.DayOfWeek != DayOfWeek.Saturday)
            {
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (holidays[j] == startDate)
                    {
                        break;
                    }
                }
                workDays++;
            }
        }
        //
        Console.WriteLine("The working days between {0} and {1} period of {2} are:\n exactly {3} days", saveStartDateForPrint, endDate, periodLength, workDays);
    }
}

