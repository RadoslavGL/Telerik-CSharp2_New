//Write a program that reads a rectangular matrix of size N x M and finds in it ...
//...the square 3 x 3 that has maximal sum of its elements.Print that sum.
//Input:
//On the first line you will receive the numbers N and M separated by a single space
//On the next N lines there will be M numbers separated with spaces - the elements of the matrix
//Output:
//Print the maximal sum of 3 x 3 square

namespace _02.Maximal_sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class MaximalSum
    {
        static void Main(string[] args)
        {

            string[] dimensions = Console.ReadLine().Split(' ');
            int N = int.Parse(dimensions[0]);
            int M = int.Parse(dimensions[1]);

            int[,] matrix = new int[N, M];

            FillingMatrix(matrix);

            int currentSum = 0;
            int maxSum = 0;

            CalculatingMaxSum(matrix, ref currentSum, ref maxSum);

            Console.WriteLine(maxSum);

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write("{0} ", matrix[row, col]);
            //    }
            //    Console.WriteLine();
            //}
        }

        private static void CalculatingMaxSum(int[,] matrix, ref int currentSum, ref int maxSum)
        {
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
        }

        private static void FillingMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] cells = Console.ReadLine().Split(' ');

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(cells[col]);
                }
            }
        }
    }
}
