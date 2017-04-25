//Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
//Can you do it with only one loop (with single scan through the elements of the array)?

//Input:On the first line you will receive the number N
//On the next N lines the numbers of the array will be given

//Output: Print the maximal sum of consecutive numbers

namespace _08.Maximal_sum
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

            int currentSum = 0;
            int maxSum = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                if ((numbers[j] + currentSum) > 0)
                {
                    currentSum += numbers[j];
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                    }
                }
                else
                {
                    currentSum = 0;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
