﻿using System.Collections.Generic;
using System.Linq;

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
            for (int i = 0; i < list.Count; i += list.Count / 4)
            {
                var newArray = new List<int>(list.Skip(i).Take(list.Count / 4));
                AA.Add(MergeSort(newArray, k));
            }

            //merge 
            var mergeArray = new List<int>();
            var tempArray = new List<int>();
            do
            {
                for (int l = 0; l < AA.Count; l++)
                {
                    if (AA[l].Count != 0)
                    {
                        tempArray.Add(AA[l][0]);
                        AA[l].RemoveAt(0);
                    }
                }
                tempArray.Sort();
                mergeArray.Add(tempArray[0]);
                tempArray.RemoveAt(0);

            } while (tempArray.Count != 0);

            return mergeArray;
        }
    }
}
