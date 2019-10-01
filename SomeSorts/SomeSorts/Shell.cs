using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSorts
{
    class Shell
    {
        public int iterations = 0;
        public int changes = 0;
        public System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        public int[] startSorting(int[] arr)
        {
            timer.Start();
            int[] sortedArr = new int[arr.Length];
            arr.CopyTo(sortedArr, 0);
            int i, j, pos, temp;
            pos = 3;
            while (pos > 0)
            {
                for (i = 0; i < sortedArr.Length; i++)
                {
                    j = i;
                    temp = sortedArr[i];
                    while ((j >= pos) && (sortedArr[j - pos] > temp))
                    {
                        sortedArr[j] = sortedArr[j - pos];
                        j = j - pos;
                        iterations++;
                    }
                    sortedArr[j] = temp;
                    changes++;
                }
                if (pos / 2 != 0)
                    pos = pos / 2;
                else if (pos == 1)
                    pos = 0;
                else
                    pos = 1;
            }
            timer.Stop();
            return sortedArr;
        }
    }
}
