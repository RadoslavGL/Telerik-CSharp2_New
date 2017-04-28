//Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.
//https://en.wikipedia.org/wiki/Binary_search_algorithm

//Input:
//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//On the last line you will receive the number X

//Output:
//Print the index where X is in the array
//If there is more than one occurence print the first one
//If there are no occurences print -1

namespace _11.Binary_search
{
    using System;
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

            int xValue = int.Parse(Console.ReadLine());

            //int[] numbers = new int[] {1, 2, 4, 8, 16, 31, 32, 64, 77, 99 };
            //int xValue = 32;

            int left = 0;
            int right = numbers.Length - 1;
            int mid = (left + right) / 2;
            bool isFound = false;
            int indexValue = -1;

            while (right >= left && !isFound)
            {
                mid = (left + right) / 2;

                if (xValue == numbers[mid])
                {
                    isFound = true;
                    indexValue = mid;
                }
                else if (xValue > numbers[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

            }

            Console.WriteLine(indexValue);
                        
        }
    }
}
