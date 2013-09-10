using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace problem1
{
    class Program
    {
        static void Main()
        {
            string inputNumber = Console.ReadLine();
            decimal sum = 0;
            decimal currentAddition = 0;
            decimal power = 1;
            while (inputNumber != string.Empty)
            {

                if ((inputNumber.Length > 1) && (inputNumber[inputNumber.Length - 2] >= 'a') && (inputNumber[inputNumber.Length - 2] <= 'z'))
                {
                    string currentDigit = inputNumber.Substring(inputNumber.Length - 2);
                    char firstDigit = currentDigit[0];
                    char secondDigit = currentDigit[1];
                    currentAddition = ((firstDigit - 'a' + 1) * 26 + secondDigit - 'A') * power;
                    inputNumber = inputNumber.Remove(inputNumber.Length - 2);
                }

                else
                {
                    string currentDigit = inputNumber.Substring(inputNumber.Length - 1);
                    char digit = currentDigit[0];
                    currentAddition = (digit - 'A') * power;
                    inputNumber = inputNumber.Remove(inputNumber.Length - 1);
                }

                sum += currentAddition;
                power *= 168;
            }
            Console.WriteLine(sum);
        }
    }
}