using System;
	

    // Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).
     
   
     
    class QuickSort
    {
        static void Main(string[] args)
        {
            // Create an unsorted array of string elements
            string[] unsorted = { "v", "b", "o", "r", "a", "q", "k","m","n"};
     
            // Print the unsorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }
     
            Console.WriteLine();
     
            // Sort the array
            Quicksort(unsorted, 0, unsorted.Length - 1);
     
            // Print the sorted array
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }
     
            Console.WriteLine();
        }
     
        public static void Quicksort(string[] elements, int left, int right)
        {
            int i = left, j = right;
            string middle = elements[(left + right) / 2];
     
            // if you want to see whole process
            for (int k = 0; k < elements.Length; k++)
            {
                Console.Write(elements[k] + " ");
            }
            Console.Write("\"{0}\"", middle);
            Console.WriteLine();
     
            while (i <= j)
            {
                while (elements[i].CompareTo(middle) < 0)
                {
                    i++;
                }
     
                while (elements[j].CompareTo(middle) > 0)
                {
                    j--;
                }
     
                if (i <= j)
                {
                    // Swap
                    string tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;
     
                    i++;
                    j--;
                }
            }
     
            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }
     
            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }

