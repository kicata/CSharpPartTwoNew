using System;
//Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
class SequenceOfGivenSum
    {
        static void Main()
        {
            //input
            Console.Write("Enter array length N= ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter arr {0} member= ", i);
                arr[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Enter sum S= ");

            int sum = int.Parse(Console.ReadLine());
            int currentSum = 0;
            int startIndex = 0;
            int endIndex = 0;
            //searching....
            for (int i = 0; i < arr.Length-1; i++)
            {
                startIndex=i;
                currentSum=arr[i];
                for (int j = i+1; j < arr.Length; j++)
                {
                    currentSum=currentSum + arr[j];

                    if (currentSum>sum)
                    {//is found
                        
                        break;
                    }
                    else if (currentSum==sum)
                    {
                        endIndex = j;
                        int lenghtSequence = endIndex - startIndex;
                        Console.WriteLine("The sequence that has sum of {0} is :", sum);

                        for (int k = startIndex; k <= endIndex; k++)
                        {
                            Console.Write(arr[k] + ", ");
                        }
                        return;
                    }
                }

            }
            
        }
    }

