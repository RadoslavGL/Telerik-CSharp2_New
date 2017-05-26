//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
//Input:
//On the first line you will receive the numbers N and M separated by a single space
//On the next N lines there will be M numbers separated with spaces - the elements of the matrix
//Output
//Print the size of the largest area of equal neighbour elements

//Input	Output
//5 6
//1 3 2 2 2 4
//3 3 3 2 4 4
//4 3 1 2 3 3
//4 3 1 3 3 1
//4 3 3 3 1 1	13

namespace _07.Largest_area_in_matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class LargestAreaInMatrix
    {
        static void Main(string[] args)
        {
            //string[] dimensions = Console.ReadLine().Split(' ');
            //int N = int.Parse(dimensions[0]);
            //int M = int.Parse(dimensions[1]);

            //int[,] matrix = new int[N, M];

            //for (int row = 0; row < N; row++)
            //{
            //    string[] inputCells = Console.ReadLine().Split(' ');
            //    for (int col = 0; col < M; col++)
            //    {
            //        matrix[row, col] = int.Parse(inputCells[col]);
            //    }
            //}

            char[,] matrix =   {{ '*', '*', '*', '*', '*', '*', '*', '*'},
                                { '*', '1', '3', '2', '2', '2', '4', '*'},
                                { '*', '3', '3', '3', '2', '4', '4', '*'},
                                { '*', '4', '3', '1', '2', '3', '3', '*'},
                                { '*', '4', '3', '1', '3', '3', '1', '*'},
                                { '*', '4', '3', '3', '3', '1', '1', '*'},
                                { '*', '*', '*', '*', '*', '*', '*', '*'}};


            bool[,] visitedCells = new bool[matrix.GetLength(0), matrix.GetLength(1)];



        }
    }
}
