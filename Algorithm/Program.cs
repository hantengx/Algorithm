using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        /// <summary>
        /// print action
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="x"></param>
        public static void Print<T>(T x)
        {
            Console.Write(x + ", ");
        }

        static void Main(string[] args)
        {
            var numbers = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i);
            }
            Sort.Shuffle(numbers);

            numbers.ForEach(Print);
            Console.WriteLine("");

            var result = Sort.MergeSort(numbers, 2);
            result.ForEach(Print);
        }
    }
}
