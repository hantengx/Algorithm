using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class HeapSort
    {
        /// <summary>
        /// heap sort
        /// </summary>
        /// <param name="vs"></param>
        public static List<int> Sort(List<int> vs)
        {
            //build stack
            int length = vs.Count;
            for (int i = length / 2 - 1; i >= 0; i--)
            {
                Modify(vs, i, length - 1);
            }

            //swap end and first
            for (int i = length - 1; i > 0; i--)
            {
                int max = vs[0];
                vs[0] = vs[i];
                vs[i] = max;

                //Console.WriteLine("max: " + max);
                //modify stack
                Modify(vs, 0, i - 1);
            }

            return vs;
        }

        /// <summary>
        /// swap node check every child node
        /// </summary>
        /// <param name="vs"></param>
        /// <param name="from"></param>
        protected static void Modify(List<int> vs, int from, int end)
        {
            //Console.WriteLine("join modify j: " + from);
            while (2 * from + 1 <= end)
            {
                int root = from;
                int left = 2 * from + 1;
                int right = left + 1;
                root = vs[root] < vs[left] ? left : root;
                if (right <= end)
                {
                    root = vs[root] < vs[right] ? right : root;
                }

                if (root != from)
                {
                    //Console.WriteLine("swap " + from + " and " + root);
                    int newRoot = vs[root];
                    vs[root] = vs[from];
                    vs[from] = newRoot;
                    from = root;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
