using System;
//Write a program to convert binary numbers to their decimal representation.

    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Enter binary number = ");
            string binaryNumber = Console.ReadLine();
            byte powerCounter = 0;
            int decimalNumber = 0;
            char[] arr = binaryNumber.ToCharArray();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                decimalNumber += (arr[i]-48) * (int)Math.Pow(2, powerCounter);
                powerCounter++;
            } 
            Console.WriteLine("The decimal representation of binary number {0} is {1}",binaryNumber, decimalNumber);
        }
    }

