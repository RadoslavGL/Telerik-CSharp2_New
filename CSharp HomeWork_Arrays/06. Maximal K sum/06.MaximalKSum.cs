//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find the maximal sum of K elements in the array.

//INPUT:On the first line you will receive the number N
//On the second line you will receive the number K
//On the next N lines the numbers of the array will be given

//OUTPUT:Print the maximal sum of K elements in the array

namespace _06.Maximal_K_sum
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            int[] numbers = new int[N];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[0] = int.Parse(Console.ReadLine());
            }

            //Selection Sort
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (numbers[i] > numbers[k])
                    {
                        int swap = numbers[i];
                        numbers[i] = numbers[k];
                        numbers[k] = swap;
                    }
                }
            }

            int sum = 0;
            for (int i = numbers.Length - 1; i > numbers.Length - K - 1; i--)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);

        }
    }
}
