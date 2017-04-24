//Write a program that compares two char arrays lexicographically (letter by letter).
//On the first line you will receive the first char array as a string
//On the second line you will receive the second char array as a string

//Print < if the first array is lexicographically smaller
//Print > if the second array is lexicographically smaller
//Print = if the arrays are equal

namespace _03.Compare_char_arrays
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArraysOne = Console.ReadLine().ToCharArray();
            char[] charArrayTwo = Console.ReadLine().ToCharArray();

            bool isEqual = true;

            for (int i = 0; i < Math.Min(charArraysOne.Length, charArrayTwo.Length); i++)
            {
                if (charArraysOne[i] > charArrayTwo[i])
                {
                    Console.WriteLine(">");
                    isEqual = false;
                    break;
                }

                else if (charArraysOne[i] < charArrayTwo[i])
                {
                    Console.WriteLine("<");
                    isEqual = false;
                    break;
                }
                
            }

            if (isEqual)
            {
                if (charArraysOne.Length > charArrayTwo.Length)
                {
                    Console.WriteLine(">");
                }
                else if (charArraysOne.Length < charArrayTwo.Length)
                {
                    Console.WriteLine("<");
                }
                else
                {
                    Console.WriteLine("=");
                }
            }
           

        }
    }
}
