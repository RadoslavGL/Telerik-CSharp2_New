//Write a program that finds the most frequent number in an array of N elements.
//Input:On the first line you will receive the number N
//On the next N lines the numbers of the array will be given

//Output:Print the most frequent number and how many time it is repeated
//?? Output should be REPEATING_NUMBER (REPEATED_TIMES times)

namespace _09.Frequent_number
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

            Array.Sort(numbers);

            int currentSequence = 1;
            int maxSequence = 1;
            int mostFrequent = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentSequence++;
                    mostFrequent = numbers[i];

                    if (maxSequence < currentSequence)
                    {
                        maxSequence = currentSequence;
                    }
                }
                else
                {
                    currentSequence = 1;

                }

            }

            Console.WriteLine("{0} - {1} times", mostFrequent, maxSequence);
        }
    }
}
