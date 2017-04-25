//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

//Input:On the first line you will receive the number N
//On the next N lines the numbers of the array will be given

//Output:Print the sorted array; Each number should be on a new line

namespace _07.Selection_sort
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int swap = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = swap;
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
