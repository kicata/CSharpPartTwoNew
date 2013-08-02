using System;

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

    class FromAnySystemToAnySystem
    {
        static int decimalNumber = 0;
        static int hostSystemBase ;
        static int destinationSystemBase;
        static void Main()
        {
            Console.Write("Enter host numerical system base s = ");
            int s = int.Parse(Console.ReadLine());
            hostSystemBase = s;
            Console.Write("Enter destination numerical system base d = ");
            int d = int.Parse(Console.ReadLine());
            destinationSystemBase = d;
            Console.Write("Enter number = ");
            string number = Console.ReadLine();

            decimalNumber=ConvertToDecimal(number);
           
           string finalResult = FromDecimalToDestination(decimalNumber);
           if (destinationSystemBase==2)
           {
               //adding 0 before binary number
               Console.WriteLine("The number {0} from numerical system {1} \nconverted in numerical system {2} is {3}",number,hostSystemBase, destinationSystemBase, finalResult.PadLeft(32,'0'));
           }
           else
           {
               Console.WriteLine("The number {0} from numerical system {1} \nconverted in numerical system {2} is {3}", number, hostSystemBase, destinationSystemBase, finalResult);   
           }
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
        public static string IntToHexInterpretator(int remainder)
        {
            string intToHexInterpred = "";
            switch (remainder)
            {
                case 1: intToHexInterpred = "1"; break;
                case 2: intToHexInterpred = "2"; break;
                case 3: intToHexInterpred = "3"; break;
                case 4: intToHexInterpred = "4"; break;
                case 5: intToHexInterpred = "5"; break;
                case 6: intToHexInterpred = "6"; break;
                case 7: intToHexInterpred = "7"; break;
                case 8: intToHexInterpred = "8"; break;
                case 9: intToHexInterpred = "9"; break;
                case 10: intToHexInterpred = "A"; break;
                case 11: intToHexInterpred = "B"; break;
                case 12: intToHexInterpred = "C"; break;
                case 13: intToHexInterpred = "D"; break;
                case 14: intToHexInterpred = "E"; break;
                case 15: intToHexInterpred = "F"; break;
                default: Console.WriteLine("WTF !");
                    break;
            }
            return intToHexInterpred;
        }
        private static string FromDecimalToDestination(int decimalNumber)
        {
            int remainder = 0;
            string result = "";
            if (destinationSystemBase==16)
            {
                while (decimalNumber != 0)
                {
                    remainder = decimalNumber % 16;
                    result = result + IntToHexInterpretator(remainder);
                    decimalNumber = decimalNumber / 16;
                }
            }
            else
            {
                
                while (decimalNumber != 0)
                {
                    remainder = decimalNumber % destinationSystemBase;
                    result = result + remainder.ToString();
                    decimalNumber = decimalNumber / destinationSystemBase;
                }
                
            }
            result = ReverseString(result);
            return result;
        }
        private static int ConvertToDecimal(string number)
        {
            char[] array = number.ToCharArray();
            byte powerCounter = 0;
            decimalNumber = 0;
            if (hostSystemBase==16)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    int digit = HexToIntInterpretator(array[i]);
                    decimalNumber = decimalNumber + digit * (int)Math.Pow(16, powerCounter);
                    powerCounter++;
                }
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    decimalNumber = decimalNumber + (array[i] - 48) * (int)Math.Pow(hostSystemBase, powerCounter);
                    powerCounter++;
                }
            }
            return decimalNumber;
        }
        public static string ReverseString(string s) // using this method we reverse remainders in result
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }

