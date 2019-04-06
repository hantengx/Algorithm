using System;
using System.Collections.Generic;
using System.Diagnostics;

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
            //var numbers = new List<int>();
            //for (int i = 0; i < 20; i++)
            //{
            //    numbers.Add(i);
            //}
            //Sort.Shuffle(numbers);

            //numbers.ForEach(Print);
            //Console.WriteLine("");

            ////var result = Sort.MergeSort(numbers, 2);
            //var result = HeapSort.Sort(numbers);
            //result.ForEach(Print);
            //TestPerformance(999, 1000);
            Console.WriteLine("reuslt: " + ReverseString("hello!"));
        }

        private static void TestPerformance(int numberCount, int times)
        {
            var numbers = new List<int>();
            for (int i = 0; i < numberCount; i++)
            {
                numbers.Add(i);
            }

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < times; i++)
            {
                Sort.Shuffle(numbers);
                var result = HeapSort.Sort(numbers);
                //Sort.MergeSort(numbers, 4);
            }
            stopWatch.Stop();
            Console.WriteLine("time is: " + stopWatch.Elapsed);
        }

        public static string ReverseString(string s)
        {
            int length = s.Length;
            char[] dst = new char[length];
            int index = length - 1;
            foreach (var c in s)
            {
                dst[index] = c;
                index--;
            }

            return new string(dst);
        }
    }
}
