using System;
using System.Collections.Generic;

//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).


class MergeSortAlgorithm
{
    static void Main()
    {
        List<int> listToSort = new List<int> { 15, 456, 17, 1, 0, 12, 456, 8, 6548, -9 };
        List<int> result = MergeSortAlg(listToSort);

        //printing result

        foreach (var member in result)
        {
            Console.Write("{0}, ", member);
        }
        Console.WriteLine();
    }
    static List<int> MergeSortAlg(List<int> unsortedList)
    {
        if (unsortedList.Count <= 1)
        {
            return unsortedList;
        }
        List<int> Left = new List<int>();
        List<int> Right = new List<int>();
        int middle = unsortedList.Count / 2;

        //split to two parts
        for (int i = 0; i < middle; i++)
        {
            Left.Add(unsortedList[i]);
        }
        for (int i = middle; i < unsortedList.Count; i++)
        {
            Right.Add(unsortedList[i]);
        }
        //recursion
        Left = MergeSortAlg(Left);
        Right = MergeSortAlg(Right);
        //recursion out
        return MergeList(Left, Right);
    }
    static List<int> MergeList(List<int> Left, List<int> Right)
    {
        List<int> sortedList = new List<int>();
        while (Left.Count > 0 || Right.Count > 0)
        {
            //both list have members
            if (Left.Count > 0 && Right.Count > 0)
            {

                if (Left[0] <= Right[0])
                {
                    sortedList.Add(Left[0]);
                    Left.RemoveAt(0);

                }
                else
                {
                    sortedList.Add(Right[0]);
                    Right.RemoveAt(0);
                }

            }
            //only one has members 
            else if (Left.Count > 0)
            {
                sortedList.Add(Left[0]);
                Left.RemoveAt(0);
            }
            else if (Right.Count > 0)
            {
                sortedList.Add(Right[0]);
                Right.RemoveAt(0);
            }
        }
        return sortedList;
    }
    
}




