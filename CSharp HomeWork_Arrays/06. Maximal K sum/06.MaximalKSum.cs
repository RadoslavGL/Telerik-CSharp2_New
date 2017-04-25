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
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //Console.WriteLine(string.Join(", ", numbers));
            
            //Selection Sort
            for (int i = 0; i < numbers.Length - 1; i++)
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

            //Console.WriteLine(string.Join(", ", numbers));

            int sum = 0;
            for (int i = N - 1; i > N - 1 - K; i--)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);

        }
    }
}
