using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that generates and prints to the console 10 random values in the range [100, 200].


    class TenRandomValues
    {
        static void Main()
        {
            Random randomGenerator = new Random();
            for (int i = 0; i < 9; i++)
            {
                int randomNumber = randomGenerator.Next(100, 200);
                Console.WriteLine(randomNumber);
            }
        }
    }

