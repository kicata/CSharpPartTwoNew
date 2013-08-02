using System;
using System.Linq;
//Write a program that finds the largest area of equal neighbor elements
//in a rectangular matrix and prints its size

class LargestAreaOfEqualNeighborElement
{
    static int[,] matrix =
        {
            {1,4,5,6,7,8,3},
            {1,5,5,5,5,8,3},
            {1,4,5,6,7,8,3},
            {1,5,5,5,5,8,5},
            {1,4,5,6,7,5,3},
            {1,4,5,6,7,5,3},
            {4,7,5,5,9,6,1}
        };
    static int currentNumber = 0;
    static int count = 0;
    static int element = 0;

    static void FindExit(int row, int col)
    {
        if ((col < 0 || row < 0) || (col > matrix.GetLength(1) || row > matrix.GetLength(0)))
        {
            //out of the matrix
            return;
        }
        if (matrix[row, col] == 0)
        {
            //the current cell is being visited
            return;
        }
        currentNumber = matrix[row, col];
        //mark the current cell as visited
        matrix[row, col] = 0;

        //explore directions
        //left
        if (col - 1 >= 0 && matrix[row, col - 1] == currentNumber)
        {
            FindExit(row, col - 1);
        }
        //up
        if (row - 1 >= 0 && matrix[row - 1, col] == currentNumber)
        {
            FindExit(row - 1, col);
        }
        //right
        if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == currentNumber)
        {
            FindExit(row, col + 1);
        }
        //down
        if (row + 1 < matrix.GetLength(0) && matrix[row + 1, col] == currentNumber)
        {
            FindExit(row + 1, col);
        }
        count++;
        return;

    }
    static void Main()
    {
        int finalCount = 0;
        int maxRepeatElement = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] != 0)
                {
                    count = 0;
                    element = matrix[row, col];
                    bool checker = false;
                    FindExit(row, col);
                    if (count > finalCount)
                    {
                        finalCount = count;
                        checker = true;
                        if (checker)
                        {
                            maxRepeatElement = element;
                        }
                    }

                }
            }

        }
        Console.WriteLine("The larger area/sequence/ of equal elements is {0}", finalCount);
        Console.WriteLine("The repeated element is {0}", maxRepeatElement);
    }
}

