//Write a program that finds the length of the maximal increasing sequence in an array of N integers.
//Input:On the first line you will receive the number N
//On the next N lines the numbers of the array will be given

//Output:Print the length of the maximal increasing sequence

namespace _05.Maximal_increasing_sequence
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

            int sequence = 1;
            int maxSequence = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] < numbers[i])
                {
                    sequence++;

                    if (maxSequence < sequence)
                    {
                        maxSequence = sequence;
                    }

                }
                else
                {
                    sequence = 1;
                }
            }

            Console.WriteLine(maxSequence);
        }
    }
}
