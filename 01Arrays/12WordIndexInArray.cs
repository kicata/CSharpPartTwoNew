using System;
//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

    class WordIndexInArray
    {
        static void Main()
        {
            Console.Write("Enter a word here :");
            string word = Console.ReadLine();
            //generate an array from chars
            int n = 26;

            char[] alpha = new char[n * 2];

            char letterValue = 'A';
            
            for (int i = 0; i < n; i++)
            {
                alpha[i] = letterValue;
                letterValue++;
            }
            letterValue = 'a';

            for (int i = n; i < alpha.Length; i++)
            {
                alpha[i] = letterValue;
                letterValue++;
            }
            //calculate length of the word
            int length = word.Length;
            Console.WriteLine("The letter index of word \"{0}\" are: ",word);
            //search and print

            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k < alpha.Length; k++)
                {
                    if (word[j] == alpha[k])
                    {
                        Console.Write(k + ",");
                    }  
                }
                
            }
        }
    }

