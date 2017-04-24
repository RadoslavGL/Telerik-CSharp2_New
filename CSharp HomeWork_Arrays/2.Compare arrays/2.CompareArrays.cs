//Write a program that reads two integer arrays of size N from the console and compares them element by element.
//On the first line you will receive the number N
//On the next N lines the numbers of the first array will be given
//On the next N lines the numbers of the second array will be given

//Print Equal if the two arrays are the same and Not equal if they are not

namespace _2.Compare_arrays
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] numbersOne = new int[N];
            for (int i = 0; i < numbersOne.Length; i++)
            {
                numbersOne[i] = int.Parse(Console.ReadLine());
            }

            int[] numbersTwo = new int[N];
            for (int i = 0; i < numbersTwo.Length; i++)
            {
                numbersTwo[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool isEqual = true;
            int counter = 0;
            while (isEqual && counter < N)
            {
                if (numbersOne[counter] != numbersTwo[counter])
                {
                    isEqual = false;
                }

                counter++;
            }

            Console.WriteLine("{0}", isEqual ? "Equal": "Not Equal");
        }
    }
}
