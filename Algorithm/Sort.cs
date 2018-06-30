using System.Collections.Generic;
using System.Linq;
using System;

namespace Algorithm
{
    class Sort
    {
        /// <summary>
        /// 归并排序
        /// </summary>
        /// <param name="list"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static List<int> MergeSort(List<int> list, int k)
        {
            if (list.Count == 1)
            {
                return list;
            }

            var AA = new List<List<int>>();
            for (int i = 0; i < list.Count; i += list.Count / k)
            {
                var newArray = new List<int>(list.Skip(i).Take(list.Count / k));
                AA.Add(MergeSort(newArray, k));
            }

            //merge 
            var mergeArray = new List<int>();
            var tempArray = new List<int>();
            do
            {
                for (int j = 0; j < AA.Count; j++)
                {
                    if (AA[j].Count != 0)
                    {
                        tempArray.Add(AA[j][0]);
                        AA[j].RemoveAt(0);
                    }
                }
                tempArray.Sort();
                mergeArray.Add(tempArray[0]);
                tempArray.RemoveAt(0);

            } while (tempArray.Count != 0);

            return mergeArray;
        }

        public static void Shuffle<T>(List<T> ts)
        {
            var random = new Random();
            var length = ts.Count;
            for (int i = length - 1; i > 0; i--)
            {
                var index = random.Next(i + 1);
                var tmp = ts[index];
                ts[index] = ts[i];
                ts[i] = tmp;
            }
        }
    }
}
