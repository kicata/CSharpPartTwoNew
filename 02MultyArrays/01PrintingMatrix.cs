using System;
using System.Linq;
//Write a program that rowsills and prints a matrix orows size (n, n) as shown below:

    class PrintingMatrix
    {
        static void Main()
        {
            Console.WriteLine("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            // print  matrix
            Console.WriteLine("A :");
            MatrixByColumn(n, matrix);
            PrintMatrix(matrix);

            Console.WriteLine("B :");
            MatrixByZigZag(n, matrix);
            PrintMatrix(matrix);

            Console.WriteLine("C :");
            MatrixByDiagonal(n, matrix);
            PrintMatrix(matrix);

            Console.WriteLine("D :");
            MatrixBySpiral(n, matrix);
            PrintMatrix(matrix);
        }

        //Methods
        private static void PrintMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write("{0}", matrix[rows, cols].ToString().PadLeft(3));
                }
                Console.WriteLine();
            }
        }
        private static void MatrixByDiagonal(int n, int[,] matrix)
        {
            int maxRow = n - 1;
            int count = 1;
            int maxDiag=(n * 2) - 1;
            for (int diag = 0; diag < maxDiag; diag++)
            {
                int row = maxRow - diag;

                if (row < 0)
                {
                    row = 0;
                }
                int col = 0;
                if (diag >= n)
                {
                    col = diag - n + 1;
                }
                while ((row < n) && (col < n))
                {
                    matrix[row, col] = count;
                    count++;
                    row++;
                    col++;
                }
            }
        }

        private static void MatrixByColumn(int n, int[,] matrix)
        {
            int maxRow = n - 1;
            int minRow = 0;
            int minCol = 0;
            int maxCount = n * n;
            int count = 1;
            while (count < maxCount + 1)
            {
                //down
                for (int row = minRow; row <= maxRow; row++)
                {
                    matrix[row, minCol] = count;
                    count++;
                }
                minCol++;
            }
        }

        private static void MatrixByZigZag(int n, int[,] matrix)
        {
            int maxRow = n - 1;
            int minRow = 0;
            int minCol = 0;
            int maxCount = n * n;
            int count = 1;

            while (count < maxCount + 1)
            {
                //down
                for (int row = minRow; row <= maxRow; row++)
                {
                    matrix[row, minCol] = count;
                    count++;
                }
                minCol++;
                //up
                for (int row = maxRow; row >= minRow; row--)
                {
                    matrix[row, minCol] = count;
                    count++;
                }
                minCol++;

            }
        }

        private static void MatrixBySpiral(int n, int[,] matrix)
        {
            int maxRow = n - 1;
            int minRow = 0;
            int maxCol = n - 1;
            int minCol = 0;
            int maxCount = n * n;
            int count = 1;

            while (count < maxCount + 1)
            {
                for (int col = minCol; col <= maxCol; col++)
                {
                    matrix[minRow, col] = count;
                    count++;
                }
                minRow++;
                //top right
                for (int row = minRow; row <= maxRow; row++)
                {
                    matrix[row, maxCol] = count;
                    count++;
                }
                maxCol--;
                //bottom right
                for (int col = maxCol; col >= minCol; col--)
                {
                    matrix[maxRow, col] = count;
                    count++;
                }
                maxRow--;
                //bottom left

                for (int row = maxRow; row >= minRow; row--)
                {
                    matrix[row, minCol] = count;
                    count++;
                }
                minCol++;
                //left top
            }
        }
    }

