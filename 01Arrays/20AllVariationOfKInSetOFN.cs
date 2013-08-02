using System;
// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
//Example:
//	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

class AllVariationOfKInSetOFN
{
    static int numberOfElements;
    static int numbersInSet;
    static int[] loops;
    static void Main()
    {
        Console.Write("N = ");
        numbersInSet = int.Parse(Console.ReadLine());

        Console.Write("K = ");
        numberOfElements = int.Parse(Console.ReadLine());

        loops = new int[numberOfElements];
        NestedElements(0);
    }
    static void NestedElements(int currentElement)
    {
        if (currentElement == numberOfElements)
        {
            PrintVariants();
            return;
        }
        for (int counter = 1; counter <= numbersInSet; counter++)
        {
            loops[currentElement] = counter;
            NestedElements(currentElement + 1);
        }
    }
    static void PrintVariants()
    {
        for (int i = 0; i < numberOfElements; i++)
        {
            Console.Write("{0} ", loops[i]);
        }
        Console.WriteLine();
    }
}
