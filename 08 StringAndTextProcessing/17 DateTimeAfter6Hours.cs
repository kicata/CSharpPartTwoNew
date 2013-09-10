using System;
using System.Linq;
using System.Globalization;
using System.Threading;
//Write a program that reads a date and time given in the format: day.month.year hour:minute:second
//and prints the date and time after 6 hours and 30 minutes (in the same format)
//along with the day of week in Bulgarian.

class DateTimeAfter6Hours
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter date informat /day.month.year hour:minute:second/ :");
        string inputDate = Console.ReadLine();
        string format = "dd.MM.yyyy hh:mm:ss";
        DateTime curntDate = DateTime.ParseExact(inputDate, format, CultureInfo.InvariantCulture);
        DateTime after6Hours = curntDate.AddHours(6).AddMinutes(30);

        Console.WriteLine(after6Hours.ToString("F",
                          CultureInfo.CreateSpecificCulture("bg-BG")));
    }
}

