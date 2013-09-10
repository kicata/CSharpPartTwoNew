using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    private static int width, height, depth, sliceCount;
    private static int[, ,] cube;

    static void Main()
    {
        ReadInput();
        long totalSum=TotalSum(cube);
        SearchForSlice(totalSum);
       


    }

    private static long TotalSum(int[, ,] cube)
    {
        long totalSum = 0;
        for (int w = 0; w < width; w++)
        {
            for (int h = 0; h < height; h++)
            {
                for (int d = 0; d < depth; d++)
                {
                    totalSum += cube[w, h, d];
                }
            }
        }
        return totalSum;
    }

    private static void PrintResult()
    {
       
    }

    private static void SearchForSlice(long totalSum)
    {
        sliceCount = 0;
        long sum = totalSum;
        long currentSum = 0;
        //horizontal
        currentSum = 0;
        for (int h = 0; h < height-1; h++)
        {
            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    currentSum = currentSum + cube[w, h, d];
                }
            }
            if (currentSum*2==sum)
            {
                sliceCount++;
            }
        }
        currentSum = 0;
        for (int w = 0; w < width - 1; w++)
        {
            for (int d = 0; d < depth; d++)
            {
                for (int h = 0; h < height; h++)
                {
                    currentSum = currentSum + cube[w, h, d];
                }
            }
            if (currentSum * 2 == sum)
            {
                sliceCount++;
            }
        }
        currentSum = 0;
        for (int d = 0; d < depth - 1; d++)
        {
            for (int w = 0; w < width; w++)
            {
                for (int h = 0; h < height; h++)
                {
                    currentSum = currentSum + cube[w, h, d];
                }
            }
            if (currentSum * 2 == sum)
            {
                sliceCount++;
            }
        }
        Console.WriteLine(sliceCount);

        
    }
    private static void ReadInput()
    {
        string[] rawNum = Console.ReadLine().Split();
        width = int.Parse(rawNum[0]);
        height = int.Parse(rawNum[1]);
        depth = int.Parse(rawNum[2]);
        cube = new int[width, height, depth];
        for (int h = 0; h < height; h++)
        {
            string[] line = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            for (int d = 0; d < depth; d++)
            {
                string[] partOfLine = line[d].Split();
                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = int.Parse(partOfLine[w]);
                }
            }
        }
    }
}

