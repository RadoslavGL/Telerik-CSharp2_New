//Write a program that sorts an array of integers using the Quick sort algorithm.
//https://en.wikipedia.org/wiki/Quicksort

//Input:
//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given

//Output:
//Print the sorted array; Each number should be on a new line

namespace _14.Quick_sort
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

            QuickSorter(numbers, 0, numbers.Length - 1);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        private static void QuickSorter(int[] numbers, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(numbers, left, right);
                QuickSorter(numbers, left, pivot - 1);
                QuickSorter(numbers, pivot + 1, right);
            }
        }

        private static int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (pivot > numbers[left])
                {
                    left++;
                }

                while (pivot < numbers[right])
                {
                    right--;
                }

                if (numbers[right] == pivot && numbers[left] == pivot)
                {
                    left++;
                }

                if (left >= right)
                {
                    return right;
                }            
                
                int swap = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = swap;

            }

        }

    }
}
