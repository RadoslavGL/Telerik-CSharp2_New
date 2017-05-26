//You are given an array of strings. Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).

namespace _05.Sort_by_string_length
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SortByStringLength
    {
        static void Main(string[] args)
        {
            string[] stringArr = new string[] 
            {
                "aaaa",
                "aa",
                "bb",
                "abcdefg",
                "123456pp",
                "AAAA",
                "BB"
            };

            ////---------with order by
            //stringArr = stringArr.OrderBy(str => str.Length).ToArray();

            //-----------Sort & CompareTo
            Array.Sort(stringArr, (x, y) => x.Length.CompareTo(y.Length));


            //print
            Console.WriteLine(string.Join("\n", stringArr));
        }
    }
}
