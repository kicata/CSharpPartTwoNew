using System;
using System.Collections.Generic;
using System.Linq;
//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets
//of several neighbor elements located on the same line, column or diagonal. Write a program 
//that finds the longest sequence of equal strings in the matrix.
    
class SequenceInMatrix
    {
        static void Main()
        {
            string[,] matrix={
                      {"bb","aa","aa","aa","kml"},
                      {"aa","bb","kk","fv","kml"},
                      {"aa","kk","bb","kml","kml"},
                      {"kk","nn","bb","bb","kml"},
                      {"kk","nn","bb","vf","kml"}
                      };
            //variables
            
            int sequenceLength = 1;
            int bestSequenceLength = 1;
            string bestRepeatedElement = "";
            string direction = "";
            int[] SequenceContainer = new int[4];
            string[] directionContainer = { "Horizontal", "Vertical", "Left to Right Diagonal", "Right to Left Diagonal", };
            string[] element = new string[4];
             // horizintal Search

            direction = "horizontal";

                for (int rows = 0; rows < matrix.GetLength(0); rows++)
                {
                    sequenceLength = 1;
                    for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                    {
                       
                            if (matrix[rows, cols] == matrix[rows, cols + 1])
                            {
                                sequenceLength++;
                            }
                            else
                            {
                                sequenceLength = 1; 
                            }
                            if (bestSequenceLength < sequenceLength)
                            {
                                bestSequenceLength = sequenceLength;
                                bestRepeatedElement = matrix[rows, cols];
                            }
                                
                    }
                    
                }
               // Console.WriteLine("direction-> {0}, count-> {1}, element-> {2}", direction, bestSequenceLength, bestRepeatedElement);
                SequenceContainer[0] = bestSequenceLength;
                element[0] = bestRepeatedElement;

            //vertical direction
            direction = "vertical";
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                sequenceLength = 1;
                for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
                {
                   
                        if (matrix[rows,cols] == matrix[rows+1,cols])
                        {
                            sequenceLength++;
                        }
                        else
                        { 
                            sequenceLength = 1; 
                        }
                        if (sequenceLength > bestSequenceLength)
                        {
                            bestSequenceLength = sequenceLength;
                            bestRepeatedElement = matrix[rows,cols] ;
                        }
                    
                }

            }
            //Console.WriteLine("direction-> {0}, count-> {1}, element-> {2}", direction, bestSequenceLength, bestRepeatedElement);
            SequenceContainer[1] = bestSequenceLength;
            element[1] = bestRepeatedElement;

            //Left Diagonal

            direction = "LeftDiagonal";
            bestSequenceLength = 1;
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    sequenceLength = 1;
                    for (int rows = i,cols = j;rows < matrix.GetLength(0)-1 && cols < matrix.GetLength(1)-1;rows++,cols++)
                    {
                          if (matrix[rows, cols] == matrix[rows + 1, cols+1])
                        {
                            sequenceLength++;
                        }
                        else
                        {
                            sequenceLength = 1;
                        }
                        if (sequenceLength > bestSequenceLength)
                        {
                            bestSequenceLength = sequenceLength;
                            bestRepeatedElement = matrix[rows, cols];
                        }  
                    }
                }
            }
           // Console.WriteLine("direction-> {0}, count-> {1}, element-> {2}", direction, bestSequenceLength, bestRepeatedElement);
            SequenceContainer[2] = bestSequenceLength;
            element[2] = bestRepeatedElement;

            //diagonal right

            direction = "RigthDiagonal";
            bestSequenceLength = 1;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    sequenceLength = 1;
                   for (int rows = i, cols = j; rows < matrix.GetLength(0) - 1 && cols > 0; rows++, cols--)
                    {
                        if (matrix[rows, cols] == matrix[rows + 1, cols-1])
                        {
                            sequenceLength++;
                        }
                        else
                        {
                            sequenceLength = 1;
                        }
                        if (sequenceLength > bestSequenceLength)
                        {
                            bestSequenceLength = sequenceLength;
                            bestRepeatedElement = matrix[rows, cols];
                        }
                    }
                }
            }
            Console.WriteLine("direction-> {0}, count-> {1}, element-> {2}", direction, bestSequenceLength, bestRepeatedElement);
            SequenceContainer[3] = bestSequenceLength;
            element[3] = bestRepeatedElement;

            //printing the result

            int maxRepeat =  SequenceContainer.Max();
            int maxRepeatIndex = Array.IndexOf(SequenceContainer, maxRepeat);

            Console.WriteLine(" The max repeat element is-> {0} ,count-> {1} in direction-> {2} ",element[maxRepeatIndex], maxRepeat, directionContainer[maxRepeatIndex] );
           
        }
    }
