using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a method that returns the last digit of given integer as an English word.
//Examples: 512  "two", 1024  "four", 12309  "nine".


    class LastDigitInEnglish
    {
        static void Main()
        {
            Console.Write("Enter an integer number ");
            int number = int.Parse(Console.ReadLine());
            int digit = number % 10;

            string temp = DigitAsWord(digit);
            Console.WriteLine("The last digit is {0}",temp);

        }
        public static string DigitAsWord(int digit)
        {
          string toWord = "";
          switch (digit)
            {
                case 0: toWord ="Zero"; break;
                case 1: toWord = "One"; break;
                case 2: toWord = "Two"; break;
                case 3: toWord = "Tree"; break;
                case 4: toWord = "Four"; break;
                case 5: toWord = "Five"; break;
                case 6: toWord ="Six"; break;
                case 7: toWord ="Seven"; break;
                case 8: toWord ="Eight"; break;
                case 9: toWord ="Nine"; break;
                default: Console.WriteLine("WTF ?"); 
                    break;  
            }
          return toWord;
        }
        

    }

