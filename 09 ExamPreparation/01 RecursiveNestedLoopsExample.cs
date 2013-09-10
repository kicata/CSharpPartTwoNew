using System;
class RecursiveNestedElements
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
        NestedElements(currentElement+1);
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