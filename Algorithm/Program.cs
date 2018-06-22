using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numbers = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i);
            }
            Sort.Shuffle(numbers);
            numbers.ForEach(x => Console.Write(x + ","));
            Console.WriteLine("");

            var result = Sort.MergeSort(numbers, 4);
            result.ForEach(x => Console.Write(x + ","));
        }
    }
}
