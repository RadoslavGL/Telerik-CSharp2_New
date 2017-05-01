//Write a program that reads an array of integers and removes from it a minimal number of elements in such a way 
//that the remaining array is sorted in increasing order. 
//Print the minimal number of elements that need to be removed in order for the array to become sorted.

//Longest increasing subsequence problem
//https://www.youtube.com/watch?v=fsCLjcZwfhY

//Input:
//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given

//Output:Print the minimal number of elements that need to be removed

namespace _18.Remove_Elements_From_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[N];
            InputValuesToArray(numbers);

            int[] maxSub = new int[numbers.Length];
            maxSub = Enumerable.Repeat(1, numbers.Length).ToArray();
            FillMaxSub(numbers, maxSub);

            Console.WriteLine(numbers.Length - maxSub.Max());

        }

        private static void InputValuesToArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        private static void FillMaxSub(int[] numbers, int[] maxSub)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((numbers[i] >= numbers[j]) && (maxSub[i] < (maxSub[j] + 1)))
                    {
                        maxSub[i] = maxSub[j] + 1;
                    }
                }
            }
        }
    }
}
