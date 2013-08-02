using System;
using System.Linq;

//Write a program that reads two numbers N and numberOfElementsForCombination and generates all the combinations of numberOfElementsForCombination distinct elements from the set [1..N].
//Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

    class GenerateCombinationOfnumberOfElementsForCombination
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of elements N:");
            long numberOfElements = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter K:");
            long numberOfElementsForCombination = long.Parse(Console.ReadLine());
            long[] elements = new long[numberOfElements];
            string subset = "";
            int lengthCount = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine("Enter member № {0}", i + 1);
                elements[i] = long.Parse(Console.ReadLine());
            }
            int maxSubsets = (int)Math.Pow(2, numberOfElements);
            for (int i = 1; i < maxSubsets; i++)
            {
                subset = "";
                for (int j = 0; j <= numberOfElements; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        subset = subset + " " + elements[j];
                        lengthCount++;
                    }
                }
                if (lengthCount == numberOfElementsForCombination)
                {
                    Console.WriteLine(subset);
                }
                lengthCount = 0;
            }
        }
    
}
