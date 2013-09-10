using System;
using System.Collections.Generic;
using System.Linq;

    //class MergeSortAlgo
    //{
    //    static void Main()
    //    {
    //        int[,] matrix = {
    //                        {1,2,3,6,8,},
    //                        {3,4,7,9,10,}
    //                        };
    //        for (int i = 0; i < matrix.GetLength(0); i++)
    //        {
    //            for (int j = 0; j < matrix.GetLength(1); j++)
    //            {
    //                Console.Write(matrix[i,j]+", ");
    //            }
    //            Console.WriteLine();
    //        }
    //        string [] array={"dasd","fgdfg", "asdd"};

    //        List<string> theList = array.ToList();
    //        foreach (var item in theList )
    //        {
    //            Console.Write(item+" ");
    //        }


    //        //List<string> lst = array.OfType<string>().ToList();
    //    }
    //}
//class SystemTest
//{
//    static void Main()
//    {
//        int sum = 0;
//        int startTime = Environment.TickCount;
//        // The code fragment to be tested
//        for (int i = 0; i < 10000000; i++)
//        {
//            sum++;
//        }
//        int endTime = Environment.TickCount;
//        Console.WriteLine("The time elapsed is {0} sec.",
//        (endTime - startTime) / 1000.0);
//    }
//}
/////////
class RandomNumbersBetween1and49
{
    static void Main()
    {
        Random rand = new Random();
        for (int number = 1; number <= 6; number++)
        {
            int randomNumber = rand.Next(49) + 1;
            Console.Write("{0} ", randomNumber);
        }
    }
}