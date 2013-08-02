using System;
//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

class BinaryRepresentOf16bitShort
{
    static void Main()
    {
        Console.Write("Please enter short number = ");
        short number = short.Parse(Console.ReadLine());

        string result = "";

        for (int i = 15; i >= 0; i--)
        {
            int mask = 1 << i;
            int nAndMask = number & mask;
            int bit = nAndMask >> i;

            if (bit == 1)
            {
                result += "1";
            }
            else
            {
                result += "0";
            }
        }
        Console.WriteLine("The binary representation of {0} is {1}",number, result);
    }    
}