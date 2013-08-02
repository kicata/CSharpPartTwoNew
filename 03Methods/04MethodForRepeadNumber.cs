using System;
using System.Linq;
//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.



    class MethodForRepeadNumber
    {
        static void Main()
        {
            int[,] matrix ={
                       {1,2,3,4,5},
                       {6,3,3,7,9},
                       {2,2,4,4,5},
                       {3,2,7,4,8},
                       {1,2,9,4,5},
                       };
            Console.Write("Enter Number to check = ");
            int number = int.Parse(Console.ReadLine());

            int temp = CountRepeatNumber(matrix, number);
            
            if (temp == 0)
            {
                Console.WriteLine("There isn't such number in the matrix. Try again");
                
            }
            else
            {
                Console.WriteLine("The number {0} appears in given matrix {1} times",number, temp);
            }

        }

        private static int CountRepeatNumber(int [,]matrix, int number)
        {
            
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == number)
                    {
                        count++;
                    }
                }
            }
            
            return count;
        }
    }

