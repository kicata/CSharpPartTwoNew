using System;
using System.Linq;
//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 
//Use try-catch-finally.

namespace _01_SqrtIntNum
{
    class SqrtIntNum
    {
        static double Sqrt(string inputNumber)
        { 
            int number;
            if (!int.TryParse(inputNumber,out number))
	        {
               throw new System.FormatException(); 
	        } 
            if (number < 0)
            {
                throw new System.ArgumentOutOfRangeException();
            }
            double result = Math.Sqrt(number);
            return result;
        }
        static void Main()
        {
            try
            {
                Console.Write("Enter int number = ");
                string inputNumber = Console.ReadLine();
                Console.WriteLine(Sqrt(inputNumber));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}
