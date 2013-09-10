using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;

//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2
//with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines 
//contain N numbers separated by space. The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4			17
//3 7 1 2
//4 3 3 2

class FindMaxPlatformInMatrix
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../matrix.txt");
        using (reader)
        {
            int n = int.Parse(reader.ReadLine());

            //creating a list to collect every row from file separetly
            List<string> rowsFromFile = new List<string>();

            int[,] array = new int[n, n];
            //reading from file and fill in the multi array
            for (int i = 0; i < n; i++)
            {
                rowsFromFile.Add(reader.ReadLine());
                string[] rowArray = rowsFromFile[i].Split(' ');

                for (int j = 0; j < n; j++)
                {
                    array[i, j] = int.Parse(rowArray[j]);
                }
            }
            //calling a method to calculate platform
            int bestSumPlatform=FindMaxPlatform(array);

            StreamWriter writer = new StreamWriter(@"../../matrixPlatform.txt", false, Encoding.GetEncoding("utf-8"));
            using (writer)
            {
                writer.Write(bestSumPlatform);
                writer.Flush();
            }
        }
        Console.WriteLine("The file with result should be in the solution folder");
    }
    public static int FindMaxPlatform(int[,] matrix)
    {
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] +
                matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        return bestSum;
    }
}

