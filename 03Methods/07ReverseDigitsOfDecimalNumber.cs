using System;
using System.Linq;
using System.Threading;
using System.Globalization;

//Write a method that reverses the digits of given decimal number. Example: 256  652

    class ReverseDigitsOfDecimalNumber
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Enter a decimal number ");
            decimal decNumber = decimal.Parse(Console.ReadLine());
            string decNumberToString = decNumber.ToString();

            Console.WriteLine("The reversed number is {0} ", ReverseDigits(decNumberToString));

        }
        public static string ReverseDigits(string number)
        {
            char [] arr = number.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }

