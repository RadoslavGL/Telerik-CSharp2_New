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
            //int N = 4;
            //char letter = 'd';

            int[,] matrix = new int[N, N];

            if (letter == 'a')
            {
                BuildMatrixA(N, matrix);

                PrintMatrix(matrix);
            }

            else if (letter == 'b')
            {
                BuildMatrixB(N, matrix);

                PrintMatrix(matrix);
            }

            else if (letter == 'c')
            {
                BuildMatrixC(N, matrix);

                PrintMatrix(matrix);
            }

            else if (letter == 'd')
            {
                BuildMatrixD(N, matrix);

                PrintMatrix(matrix);
            }
        }

        //1   12  11  10
        //2   13  16  9
        //3   14  15  8
        //4   5   6   7
        private static void BuildMatrixD(int N, int[,] matrix)
        {
            int count = 1;

            for (int i = 0; i < N; i++) // top rows and columns
            {

                //top rows and cols
                for (int j = i; j < N - i; j++)
                {
                    matrix[i, j] = count;
                    count++;
                }

                //right cols
                for (int j = 0; j < N - 1 - i * 2; j++)
                {
                    matrix[j + 1 + i, N - i - 1] = count;
                    count++;
                }

                //bottom rows and cols;
                for (int j = 0; j < N - 1 - i * 2; j++)
                {
                    matrix[N - 1 - i, N - j - 2 - i] = count;
                    count++;
                }

                //left cols
                for (int j = 0; j < N - 2 - i * 2; j++)
                {
                    matrix[N - j - 2 - i, i] = count;
                    count++;
                }
            }
        }

        //7   11  14  16
        //4   8   12  15
        //2   5   9   13
        //1   3   6   10
        private static void BuildMatrixC(int N, int[,] matrix)
        {
            int rows = 0;
            int cols = 0;
            int value = 1;

            //populate values under the main diagonal

            for (int i = N - 1; i >= 0; i--)
            {
                rows = i;
                cols = 0;
                while (rows < N && cols < N)
                {
                    matrix[rows, cols] = value;
                    rows++;
                    cols++;
                    value++;
                }
            }

            //populate values over the main diagonal

            for (int j = 1; j < N; j++)
            {
                rows = j;
                cols = 0;
                while (rows < N && cols < N)
                {
                    matrix[cols, rows] = value;
                    cols++;
                    rows++;
                    value++;
                }
            }
        }

        //1   8   9   16
        //2   7   10  15
        //3   6   11  14
        //4   5   12  13
        private static void BuildMatrixB(int N, int[,] matrix)
        {
            int count = 1;
            int currentCount = 1;

            for (int col = 0; col < N; col++)
            {
                //switches between accending and descending the same N numbers vertically;
                //if we change to matrix[col, row] we will get the same thing, but horizontally;
                for (int row = 0; row < N; row++)
                {
                    if (col % 2 == 0)
                    {
                        matrix[row, col] = count;
                        count++;
                    }
                    else
                    {
                        count--;
                        matrix[row, col] = count;

                    }

                }

                //stores the value of the counter so that it's used for 

                if (col % 2 == 0)
                {
                    currentCount = count;
                    currentCount += N;
                    count = currentCount;
                }
                else if (col % 2 != 0)
                {
                    count = currentCount;

                }
            }
        }


        //1   5   9   13
        //2   6   10  14
        //3   7   11  15
        //4   8   12  16
        private static void BuildMatrixA(int N, int[,] matrix)
        {
            int count = 0;

            for (int row = 0; row < N; row++)
            {
                count++;
                for (int col = 0; col < N; col++)
                {
                    matrix[row, col] = count;
                    count += N;
                }
                count -= N * N;
            }
        }

        //print the matrix
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
