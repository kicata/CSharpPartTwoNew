using System;

//Write a program to convert decimal numbers to their binary representation.

    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Enter number = ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int inputNumber = decimalNumber;
            int remainder = 0;
            string result = "";
            
            while (decimalNumber!=0)
            {
                remainder = decimalNumber % 2;
                result = result + remainder.ToString();
                decimalNumber = decimalNumber / 2;
            }
            Console.WriteLine("The binary representation of {0} is {1} ", inputNumber, ReverseString(result).PadLeft(32, '0'));
            
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }

