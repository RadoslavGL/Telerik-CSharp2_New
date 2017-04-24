//Write a program that finds the length of the maximal sequence of EQUAL elements in an array of N integers.
//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given

//Print the length of the maximal sequence

namespace _04_Maximal_sequence
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

            int count = 1;
            int maxCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] == numbers[i])
                {
                    count++;

                    if (maxCount < count)
                    {
                        maxCount = count;
                    }

                }

                else
                {
                    count = 1;
                }
            }

            Console.WriteLine(maxCount);

        }
    }
}
