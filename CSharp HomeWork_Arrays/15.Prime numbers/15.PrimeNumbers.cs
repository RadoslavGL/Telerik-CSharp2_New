//Write a program that finds all prime numbers in the range [1 ... N]. 
//Use the Sieve of Eratosthenes algorithm. The program should print the biggest prime number which is <= N.

//Input: On the first line you will receive the number N

//Output: Print the biggest prime number which is <= N

namespace _15.Prime_numbers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            bool[] isPrime = new bool[N];
            isPrime = Enumerable.Repeat(true, N + 1).ToArray();

            //Console.WriteLine(string.Join("\n", arrPrime));

            for (int i = 2; i <= Math.Sqrt(N); i++)
            {
                if (isPrime[i] == true)
                {
                    for (int j = i * i; j <= N; j += i)
                    {
                        isPrime[j] = false;
                    }
                }

            }

            //Console.WriteLine(string.Join("\n", arrPrime));

            for (int k = N; k >= 2 ; k--)
            {
                if (isPrime[k] == true)
                {
                    Console.WriteLine(k);
                    break;
                }
            }
        }
    }
}
