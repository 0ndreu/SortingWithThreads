using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSorts
{
    class Bubble
    {
        public int iterations = 0;
        public int changes = 0;
        public System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        private int[] BubbleSort(int[] arr)
        {
            int[] sortedArr = new int[arr.Length];
            int n = sortedArr.Length;
            timer.Start();
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < (n - 1); j++)
                {
                    if (sortedArr[j + 1] < sortedArr[j])
                    {
                        int temp = sortedArr[j + 1];
                        sortedArr[j + 1] = sortedArr[j];
                        sortedArr[j] = temp;
                        changes++;
                    }
                    iterations++;
                }
            }
            timer.Stop();
            return sortedArr;
        }
    }
}
