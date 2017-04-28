//Write a program that creates an array containing all letters from the alphabet (a-z). 
//Read a word from the console and print the index of each of its letters in the array.

//Output:
//Print the index of each of the word's letters in the array
//Each index should be on a new line

namespace _12.Index_of_letters
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine((int)word[i] - (int)'a');
            }
        }
    }
}
