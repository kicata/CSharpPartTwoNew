using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class JoroTheRabbit
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(',');
        int[] array = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            array[i] = int.Parse(input[i]);
        }
        int currentPath;
        int longestPath = 0;

        for (int startIndex = 0; startIndex < array.Length; startIndex++)
        {
            for (int step = 1; step < array.Length; step++)
            {
                int index = startIndex;
                currentPath = 1;
                int next = index + step;
                if (next>=array.Length)
                {
                    next = next-array.Length;
                }
                
                while (array[index] < array[next])
                {
                    currentPath++;
                    index = next;
                    next = (index + step) % array.Length;

                }
                if (longestPath < currentPath)
                {
                    longestPath = currentPath;
                }

            }
        }
        Console.WriteLine(longestPath);
    }
}

