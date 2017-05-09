using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.DemoSorting
{
    //public class NumbersDescendingComparer : IComparer<int>
    //{
    //    public int Compare(int x, int y)
    //    {
    //        return (-x).CompareTo(-y);
    //    }
    //}

    class DemoSorting
    {
        static void Main(string[] args)
        {
            //    //--------------------------Sorting

            //    int[] numbers = { 5, 7, 8, 2, -5, 55, 6, 7 };

            //    Array.Sort(numbers, new NumbersDescendingComparer());

            //    Console.WriteLine(string.Join(", ", numbers));

            //// ----- Lambda expressions

            //int[] numbers = { 6, 9, 2, 2, 8, 7, 5, 1 };

            //Array.Sort(numbers, (x, y) => (-x).CompareTo(-y));

            //Console.WriteLine(string.Join(", ", numbers));


            int[] numbers = { 6, 9, 2, 2, 8, 7, 5, 1 };

            numbers = numbers.OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
