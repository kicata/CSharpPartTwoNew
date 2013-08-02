using System;
// Write a program to convert decimal numbers to their hexadecimal representation.

class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Enter number = ");
            int decimalNumber = int.Parse(Console.ReadLine());
            int inputNumber = decimalNumber;
            int remainder = 0;
            string result = "";
            //calculating
            while (decimalNumber != 0)
            {
                remainder = decimalNumber % 16;
                result = result + IntToHexInterpretator(remainder);
                decimalNumber = decimalNumber / 16;
            }
            Console.WriteLine("The hexadecimal representation of {0} is {1} ", inputNumber, ReverseString(result));

        }
        public static string IntToHexInterpretator(int remainder)
        {
            string hexInterpred="";
            switch (remainder)
            {
                case 1: hexInterpred = "1"; break;
                case 2: hexInterpred = "2"; break;
                case 3: hexInterpred = "3"; break;
                case 4: hexInterpred = "4"; break;
                case 5: hexInterpred = "5"; break;
                case 6: hexInterpred = "6"; break;
                case 7: hexInterpred = "7"; break;
                case 8: hexInterpred = "8"; break;
                case 9: hexInterpred = "9"; break;
                case 10: hexInterpred = "A"; break;
                case 11: hexInterpred = "B"; break;
                case 12: hexInterpred = "C"; break;
                case 13: hexInterpred = "D"; break;
                case 14: hexInterpred = "E"; break;
                case 15: hexInterpred = "F"; break;
                default: Console.WriteLine("WTF !");
                    break;
            }
            return hexInterpred;
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }

