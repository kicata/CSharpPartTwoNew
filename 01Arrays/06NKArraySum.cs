using System;
//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.


class NKArraySum
{
    static void Main()
    {
        
        Console.WriteLine("Enter n and k integer/ n >= k /");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        if (k>n)
        {
            Console.WriteLine("Start again");
        }
        else
        {
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter array member = ");
                arr[i] = int.Parse(Console.ReadLine());

            }

            int maxKVariant = n - k;
            int maxSum = 0;
            int currentSum = 0;
            int pos = 0;
            for (int i = 0; i <=maxKVariant; i++)
            {

                for (int j = i; j < i+k; j++)
                {
                    currentSum += arr[j];  
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    pos = i;
                }
                currentSum = 0;
            }
            Console.WriteLine("the maxSum is {0} ",maxSum);
            for (int i = pos; i < pos + k; i++) 
            {
                Console.Write("{0},  ",arr[i]);
            }
        }

        
    }
}

