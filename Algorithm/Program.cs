using System;
using System.Collections.Generic;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            for (int i = 0; i < 20; i++)
            {
                int num = 0;
                numbers.Add(num);
            }
            
            var result = Sort.MergeSort(numbers, 4);

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
