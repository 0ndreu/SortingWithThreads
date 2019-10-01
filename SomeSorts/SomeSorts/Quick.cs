using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeSorts
{
    class Quick
    {
        public int iterations = 0;
        public int changes = 0;
        public System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        public int[] QuickSort(int[] arr)
        {
            int[] sortedArr = new int[arr.Length];
            arr.CopyTo(sortedArr, 0);
            int left = 0;
            int right = sortedArr.Length - 1;
            timer.Start();
            Quick_Sort(sortedArr, left, right);
            timer.Stop();
            return sortedArr;
        }

        public void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                iterations++;
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                    Quick_Sort(arr, left, pivot - 1);
                if (pivot + 1 < right)
                    Quick_Sort(arr, pivot + 1, right);
                iterations++;
                iterations++;
            }
        }

        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                    iterations++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                    iterations++;
                }
                if (left < right)
                {
                    iterations++;
                    if (arr[left] == arr[right])
                        return right;
                    iterations++;
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    changes++;
                }
                else
                    return right;
            }
        }
    }
}