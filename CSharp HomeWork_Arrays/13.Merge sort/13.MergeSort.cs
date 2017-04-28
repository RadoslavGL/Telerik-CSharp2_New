//Write a program that sorts an array of integers using the Merge sort algorithm.
//https://en.wikipedia.org/wiki/Merge_sort (Top-down implementation using lists)

//Input:
//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given

//Output:
//Print the sorted array
//  Each number should be on a new line

namespace _13.Merge_sort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            numbers = MergeSort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        private static int[] MergeSort(int[] numbers)
        {
            //base case
            if (numbers.Length <= 1)
            {
                return numbers;
            }

            //recursive case

            var left = new List<int>();
            var right = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < numbers.Length / 2)
                {
                    left.Add(numbers[i]);
                }
                else
                {
                    right.Add(numbers[i]);
                }
            }

            left = MergeSort(left.ToArray()).ToList();
            right = MergeSort(right.ToArray()).ToList();

            return Merge(left, right);
        }

        private static int[] Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();
            
            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] > right[0])
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
                else
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result.ToArray();
        }

    }
}
