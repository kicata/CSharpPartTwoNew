using System;
using System.Linq;

//Write a program to convert hexadecimal numbers to their decimal representation.


    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.Write("Enter number = ");
            string hexadecimalNumber = Console.ReadLine();
            char[] array = hexadecimalNumber.ToCharArray();
            int powerCounter=0;
            int result = 0;

            //calculating
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int digit = HexToIntInterpretator(array[i]);
                result = result + digit*(int) Math.Pow(16, powerCounter);
                powerCounter++;
            }
            
            Console.WriteLine("The decimal representation of hexnumber {0} is {1} ", hexadecimalNumber, result);

        }
        public static int HexToIntInterpretator(char digit)
        {
            int hexToIntInterpred = 0;
            switch (digit)
            {
                case '1': hexToIntInterpred = 1; break;
                case '2': hexToIntInterpred = 2; break;
                case '3': hexToIntInterpred = 3; break;
                case '4': hexToIntInterpred = 4; break;
                case '5': hexToIntInterpred = 5; break;
                case '6': hexToIntInterpred = 6; break;
                case '7': hexToIntInterpred = 7; break;
                case '8': hexToIntInterpred = 8; break;
                case '9': hexToIntInterpred = 9; break;
                case 'A': hexToIntInterpred = 10; break;
                case 'B': hexToIntInterpred = 11; break;
                case 'C': hexToIntInterpred = 12; break;
                case 'D': hexToIntInterpred = 13; break;
                case 'E': hexToIntInterpred = 14; break;
                case 'F': hexToIntInterpred = 15; break;
                default: Console.WriteLine("WTF !");
                    break;
            }
            return hexToIntInterpred;
        }
        
    }
