//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements
// located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings
// in the matrix and prints its length.

//Input:
//On the first line you will receive the numbers N and M separated by a single space
//On the next N lines there will be M strings separated with spaces - the strings in the matrix

//Output:
//Print the length of the longest sequence of equal equal strings in the matrix

namespace _03.Sequence_in_matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SequenceInMatrix
    {
        static void Main(string[] args)
        {
            string[] matrixDimensions = Console.ReadLine().Split(' ').ToArray();
            int N = int.Parse(matrixDimensions[0]);
            int M = int.Parse(matrixDimensions[1]);

            object[,] matrix = new object[N, M];

            //fill in the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] inputLine = Console.ReadLine().Split(' ').ToArray(); 
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputLine[col];
                }
            }

            int currentCount = 1;
            int maxCount = 0;

            //----vertical checks;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                currentCount = 1;
                int row = 1;
                while (row < matrix.GetLength(0))
                {
                    if (matrix[row, col] == matrix[row - 1, col])
                    {
                        currentCount++;
                        maxCount = CheckingMax(currentCount, maxCount);
                    }
                    else
                    {
                        maxCount = CheckingMax(currentCount, maxCount);
                        currentCount = 1;
                    }
                    row++;
                }
            }

            //----horizonal checks;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                currentCount = 1;
                int col = 1;
                while (col < matrix.GetLength(1))
                {
                    if (matrix[row, col] == matrix[row, col - 1])
                    {
                        currentCount++;
                        maxCount = CheckingMax(currentCount, maxCount);
                    }
                    else
                    {
                        maxCount = CheckingMax(currentCount, maxCount);
                        currentCount = 1;
                    }
                    col++;
                }
            }

            //----diagonal checks (left to right); the diagonal and below it;
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                currentCount = 1;
                int row = i + 1;
                int col = 1;
                while (row < matrix.GetLength(0) && col < matrix.GetLength(1))
                {
                    if (matrix[row, col] == matrix[row - 1, col - 1])
                    {
                        currentCount++;
                        maxCount = CheckingMax(currentCount, maxCount);
                    }
                    else
                    {
                        maxCount = CheckingMax(currentCount, maxCount);
                        currentCount = 1;
                    }
                    row++;
                    col++;
                }
            }

            //----diagonal checks (left to right); above the diagonal;
            for (int i = 1; i < matrix.GetLength(1) - 1; i++)
            {
                currentCount = 1;
                int row = 1;
                int col = i + 1;
                while (row < matrix.GetLength(0) && col < matrix.GetLongLength(1))
                {
                    if (matrix[row, col] == matrix[row - 1, col - 1])
                    {
                        currentCount++;
                        maxCount = CheckingMax(currentCount, maxCount);
                    }
                    else
                    {
                        maxCount = CheckingMax(currentCount, maxCount);
                        currentCount = 1;
                    }
                    row++;
                    col++;
                }
            }


            //----diagonal checks (right - left); the diagonal and above it;
            for (int i = 1; i < matrix.GetLength(1) - 1; i++)
            {
                int row = 1;
                int col = i;
                while (row < matrix.GetLength(0) && col >= 0)
                {
                    if (matrix[row, col] == matrix[row - 1, col + 1])
                    {
                        currentCount++;
                        maxCount = CheckingMax(currentCount, maxCount);
                    }
                    else
                    {
                        maxCount = CheckingMax(currentCount, maxCount);
                        currentCount = 1;
                    }
                    row++;
                    col--;
                }
            }

            //----diagonal checks (right - left); below the diagonal;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                int row = i + 1;
                int col = matrix.GetLength(1) - 2;
                currentCount = 1;
                while (row < matrix.GetLength(0) && col >=0)
                {
                    if (matrix[row, col] == matrix[row - 1, col + 1])
                    {
                        currentCount++;
                        maxCount = CheckingMax(currentCount, maxCount);
                    }
                    else
                    {
                        maxCount = CheckingMax(currentCount, maxCount);
                        currentCount = 1;
                    }
                    row++;
                    col--;
                }
            }
            
            Console.WriteLine(maxCount);

        }

        private static int CheckingMax(int currentCount, int maxCount)
        {
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }

            return maxCount;
        }
    }
}
