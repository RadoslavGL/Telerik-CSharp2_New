//Write a program that fills and prints a matrix of size (n, n) as shown below.
//Input: On the first line you will receive the number N
//      On the second line you will receive a character(a, b, c, d*) which determines how to fill the matrix

//Print the matrix
//Numbers on a row must be separated by a single spacebar
//Each row must be on a new line

namespace _01.Fill_the_matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            char letter = char.Parse(Console.ReadLine().ToLower());

            int[,] matrix = new int[N, N];

            int startValue = 1;

            if (letter == 'a')
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = startValue + row + col + 3 * col;
                    }

                }
            }

            //print
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();

            }
        }
    }
}
