using System;
//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)



class TheMostFrequentMemberOfArray
{
    static void Main()
    {
        Console.Write("Enter array length N= ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter arr {0} member= ",i);
            arr[i] = int.Parse(Console.ReadLine());

        }
        int count = 0;
        
        int mostFrequentNumberCount = 0;
        int frequentNumber = Int32.MinValue;
        int mostFrequentNumber=0;

        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[i]==arr[j])
                {
                    frequentNumber = arr[i];
                    count++;
                    
                }

            }
            if (mostFrequentNumberCount<count)
            {
                mostFrequentNumberCount = count;
                mostFrequentNumber = frequentNumber;   
            }
            count = 0;
            frequentNumber = Int32.MinValue;
        }
        
        Console.WriteLine("The most frequent number in an array is {0} repeated {1} times",mostFrequentNumber,mostFrequentNumberCount+1);
    }

}

