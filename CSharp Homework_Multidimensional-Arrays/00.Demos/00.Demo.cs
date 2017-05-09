

namespace _00.Demos
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Demos
    {
        static void Main(string[] args)
        {

            //matrices

            //int[,] matrix =
            //{
            //    { 5, 0, -2, 4},
            //    { 5, 6, 7, 8},
            //};

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write("{0, 3} ",matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //int[,,] cube = new int[3, 4, 5];

            //for (int i = 0; i < cube.GetLength(0); i++)
            //{
            //    for (int j = 0; j < cube.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < cube.GetLength(2); k++)
            //        {
            //            cube[i, j, k] = i * j * k;
            //        }
            //    }
            //}

            //Console.WriteLine(cube[2, 3, 4]);

            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());

            //int[,] matrix = new int[n, m];

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    string colLine = Console.ReadLine();
            //    string[] cells = colLine.Split(' ');

            //    //Console.WriteLine("Result: {0}", String.Join(", ", cells));


            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        matrix[row, col] = int.Parse(cells[col]);
            //    }
            //}

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        if (col != (matrix.GetLength(1) - 1))
            //        {
            //            Console.Write("{0}, ", matrix[row, col]);
            //        }
            //        else
            //        {
            //            Console.Write("{0}", matrix[row, col]);
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // -------------------- Maximal Platform problem

            //int[,] matrix = 
            //{
            //  {7, 1, 3, 3, 2, 1},
            //  {1, 3, 9, 8, 5, 6},
            //  {4, 6, 7, 9, 1, 0}
            //};

            //int sum = int.MinValue;
            //int maxSum = int.MinValue;

            //int bestRow = 0;
            //int bestCol = 0;

            //for (int row = 0; row < (matrix.GetLength(0) - 1); row++)
            //{
            //    for (int col = 0; col < (matrix.GetLength(1) - 1); col++)
            //    {
            //        sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
            //        if (sum > maxSum)
            //        {
            //            maxSum = sum;
            //            bestRow = row;
            //            bestCol = col;
            //        }
            //    }
            //}

            //Console.WriteLine("Best Sum = {0}",maxSum);
            //Console.WriteLine("Best Matrix:");
            //Console.WriteLine("{0}, {1}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
            //Console.WriteLine("{0}, {1}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);

            // --------------- Jagged arrays
            //int[][] jagged = new int[3][];
            //jagged[0] = new int[] { 1, 2, 3 };
            //jagged[1] = new int[] { 4, 5 };
            //jagged[2] = new int[] { 6, 7, 8, 9 };

            //for (int row = 0; row < jagged.Length; row++)
            //{
            //    for (int col = 0; col < jagged[row].Length; col++)
            //    {
            //        Console.Write("{0, 3}", jagged[row][col]);
            //    }
            //    Console.WriteLine();
            //}

            //int[][] jagged = new int[][] 
            //{
            //    new int[] { 1, 2, 3 },
            //    new int[] { 4, 5 },
            //    new int[] { 6, 7, 8, 9 }
            //};


            //for (int row = 0; row < jagged.Length; row++)
            //{
            //    for (int col = 0; col < jagged[row].Length; col++)
            //    {
            //        Console.Write("{0, 3}", jagged[row][col]);
            //    }
            //    Console.WriteLine();
            //}

            //// ------------------------ Group by remainder problem

            ////input
            //int[] numbers = Enumerable.Range(0, 10).ToArray();

            // //new array to determine the sizes of the arrays in the jagged array;
            ////for each member of numbers the value of the 0, 1st or 2nd member of sizes increases from 0;
            //int[] sizes = new int[3];

            //foreach (var number in numbers)
            //{
            //    int remainder = number % 3;
            //    ++sizes[remainder];
            //}

            ////numbersByRemainder is the jagged array;
            ////the loops sets the sizes of its arrays;
            //int[][] numbersByRemainer = new int[3][];

            //for (int i = 0; i < numbersByRemainer.Length; i++)
            //{
            //    numbersByRemainer[i] = new int[sizes[i]];
            //}

            ////indeces array - needed for storing the indexes when we fill the members of numbers array into the...
            ////... numbersByRemainder jagged array
            //int[] indeces = new int[3];

            ////filling the jagged array
            ////the number is added to an array based of the value of remainder;
            ////the position in which the number is added is set by the value of the corresponding member of ...
            ////the indeces array
            //foreach (var number in numbers)
            //{
            //    int remainder = number % 3;
            //    numbersByRemainer[remainder][indeces[remainder]] = number;
            //    ++indeces[remainder];
            //}

            ////printing
            //for (int row = 0; row < numbersByRemainer.Length; row++)
            //{
            //    Console.Write("Numbers with remainder {0} when devided by 3: ", row);
            //    for (int col = 0; col < numbersByRemainer[row].Length; col++)
            //    {
            //        if (col != (numbersByRemainer[row]. Length - 1))
            //        {
            //            Console.Write("{0}, ", numbersByRemainer[row][col]);
            //        }
            //        else
            //        {
            //            Console.WriteLine(numbersByRemainer[row][col]);
            //        }

            //    }
            //    Console.WriteLine();
            //}

            //int[] numbers = { 15, 5, 7, 8, 15, 55, 3, 14, 5, 9 };

            ////new array that counts the numbers by remainder of 3;
            //int[] countRemThree = new int[3];

            //foreach (var number in numbers)
            //{
            //    int remainder = number % 3;
            //    ++countRemThree[remainder];
            //}
            //int[][] numbersByRemainder = new int[3][]
            //{
            //    new int[countRemThree[0]],
            //    new int[countRemThree[1]],
            //    new int[countRemThree[2]]
            //};

            ////we have the jagged array with the correct sizes;
            ////now let's put the numbers in;
            ////we need some kind of counter in order to place the numbers in the correct spots;

            //int[] indeces = new int[3];

            //foreach (var number in numbers)
            //{
            //    int remainder = number % 3;
            //    numbersByRemainder[remainder][indeces[remainder]] = number;
            //    ++indeces[remainder];
            //}

            ////print to check

            //for (int i = 0; i < numbersByRemainder.GetLength(0); i++)
            //{
            //    Console.WriteLine("numbers with remainder {0}:", i);
            //    for (int j = 0; j < numbersByRemainder[i].GetLength(0); j++)
            //    {
            //        Console.WriteLine(numbersByRemainder[i][j]);
            //    }
            //}


            //// ------------------- Matrix multiplication

            //int[,] matrixA = 
            //{
            //    { 1, 2 },
            //    { 3, 4 },
            //    { 5, 6 },
            //    { 7, 8 }
            //};

            //int[,] matrixB = 
            //{
            //    { 10, 11, 12 },
            //    { 13, 14, 15 }
            //};

            ////for 2 matrices to be multipled we need:
            ////the # of columns of the first to the equal to the # of rows of the 2nd;
            //if (matrixA.GetLength(1) != matrixB.GetLength(0))
            //{
            //    Console.WriteLine("Matrices cannot be multiplied");
            //    return;
            //}

            ////dimension of the result matrix:
            ////rows - the # of rows of the 1st matrix;
            ////cols - the # of cols of the 2nd matrix;
            //int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

            ////multiplication:
            //// - position: row from the 1st matrix; column from the second matrix;
            //// - value: sum of the multiplies of the values
            ////from 1st row of the 1st matrix with the column from the 2nd matrix, 
            ////indexwise by columns and rows correspondingly;
            //for (int row = 0; row < resultMatrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < resultMatrix.GetLength(1); col++)
            //    {
            //        int value = 0;
            //        for (int i = 0; i < matrixA.GetLength(1); i++)
            //        {
            //            value += matrixA[row, i] * matrixB[i, col];
            //        }
            //        resultMatrix[row, col] = value;
            //    }
            //}

            ////print

            //for (int row = 0; row < matrixA.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrixB.GetLength(1); col++)
            //    {
            //        Console.Write("{0, 5} ", resultMatrix[row, col]);
            //    }
            //    Console.WriteLine();
            //}

            ////--------------------Pascal Triangle

            //int height = int.Parse(Console.ReadLine());

            ////jagged array create and sizes
            //// height + 1, because we want to the triangle up to that row (1st row is zero)
            //long[][] triangle = new long[height + 1][];


            //for (int i = 0; i < triangle.GetLength(0); i++)
            //{
            //    //triangle[i] = new long[triangle[i - 1].Length + 1];
            //    triangle[i] = new long[i + 1];
            //}

            ////calculate triangle

            //triangle[0][0] = 1;

            //for (int row = 1; row < triangle.Length; row++)
            //{
            //    triangle[row][0] = 1;
            //    triangle[row][row] = 1;
            //    for (int col = 1; col < row; col++)
            //    {
            //        triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
            //    }
            //}

            ////print

            //for (int row = 0; row < triangle.Length; row++)
            //{
            //    for (int col = 0; col < triangle[row].Length; col++)
            //    {
            //        Console.Write("{0, 5}", triangle[row][col]);
            //    }
            //    Console.WriteLine();
            //}

            
        }
    }
}
