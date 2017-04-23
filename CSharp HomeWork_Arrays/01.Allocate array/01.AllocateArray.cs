//Write a program that allocates array of N integers, initializes each element by its index multiplied by 5
//and the prints the obtained array on the console.

//Print the obtained array on the console. Each number should be on a new line.

namespace _01.Allocate_array
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int multiplier = 5;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * multiplier;
            }

            Console.WriteLine(string.Join("\n", numbers));
        }
    }
}
