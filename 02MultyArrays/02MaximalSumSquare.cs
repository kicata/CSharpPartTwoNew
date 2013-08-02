using System;
using System.Linq;
//Write a program that reads a rectangular matrix of size N x M and finds
//in it the square 3 x 3 that has maximal sum of its elements.

class MaximalSumSquare
{
    static void Main()
    {
        // Declare and input the matrix
        int n = 0;
        do
        {
           Console.Write("Enter rows N = ");
           n = int.Parse(Console.ReadLine()); 
        } while (n<3);

        int m = 0; 
        do
        {
            Console.Write("Enter cols M = ");
            m = int.Parse(Console.ReadLine());
        } while (m < 3);
        

        int[,] matrix = new int[n, m];
        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < m; cols++)
            {
                Console.Write("Enter  member[{0},{1}] = ",rows,cols);
                matrix[rows, cols] = int.Parse(Console.ReadLine());
            }
        }
        //Print the input matrix
        Console.WriteLine("This is the input matrix: ");
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("{0}",matrix[rows, cols].ToString().PadLeft(4));
                
            }
            Console.WriteLine();
        }

        // Find the maximal sum platform of size 3 x 3
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] +matrix[row, col + 2]+
                matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]+
                matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        
        // Print the result
        Console.WriteLine("The best platform is:");
        Console.WriteLine(" {0} {1} {2}", matrix[bestRow, bestCol],
        matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine(" {0} {1} {2}",
        matrix[bestRow + 1, bestCol],
        matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine(" {0} {1} {2}",
        matrix[bestRow + 2, bestCol],
        matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);

    }
}

