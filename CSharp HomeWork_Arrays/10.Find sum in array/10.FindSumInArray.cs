//Write a program that finds in given array of integers a sequence of given sum S (if present).
//array                 S       result
//4, 3, 1, 4, 2, 5, 8	11	    4, 2, 5

namespace _10.Find_sum_in_array
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();

            int sum = int.Parse(Console.ReadLine());

            int currentSum = 0;
            bool isSubsetFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                currentSum = numbers[i];
                string currentSequence = numbers[i] + ", ";

                if (sum == currentSum)
                {
                    isSubsetFound = true;
                    Console.WriteLine("{0}", currentSequence.TrimEnd(',', ' '));
                }

                for (int j = i+1; j < numbers.Length; j++)
                {
                    currentSum += numbers[j];
                    currentSequence += numbers[j] + ", ";

                    if (sum == currentSum)
                    {
                        isSubsetFound = true;
                        Console.WriteLine("{0}", currentSequence.TrimEnd(',', ' '));
                    }
                }

            }

            if (!isSubsetFound)
            {
                Console.WriteLine(-1);
            }
        }
    }
}
