using System;
using System.Linq;
//Write a program that reads a number and prints it as a decimal number,
//hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.
class ProgramPrintANumberManyType
    {
        static void Main()
        {
            Console.Write("Enter an integer number =");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Decimal:");
            string temp = String.Format("{0,15:D}", number);
            Console.WriteLine(temp);

            Console.WriteLine("Hexadecimal:");
            Console.WriteLine("{0,15:X}",number);

            Console.WriteLine("Percentage:");
            Console.WriteLine("{0,15:P}", number);

            Console.WriteLine("Scientific Notation:");
            Console.WriteLine("{0,15:E2}", number);
        }
    }

