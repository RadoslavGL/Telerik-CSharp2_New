//Write a program, that reads from the console an array of N integers and an integer K, 
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

namespace _04.Binary_search
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] nArray = new int[N];

            Console.Write("Enter the members of the array, devided by a single space:");
            string[] cells = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < nArray.Length; i++)
            {
                nArray[i] = int.Parse(cells[i]);
            }
            nArray = nArray.OrderBy(x => x).ToArray();

            Console.Write("Enter the value you are looking for:");
            int K = int.Parse(Console.ReadLine());

            Console.WriteLine(Array.BinarySearch(nArray, K)); 

        }
    }
}
