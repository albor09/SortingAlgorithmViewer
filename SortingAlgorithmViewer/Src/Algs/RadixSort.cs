using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmViewer.Src.Algs
{
    internal class RadixSort : Algorithm
    {
        public int GetMax(SortingArray arr, int n)
        {
            int mx = arr[0];
            for (int i = 1; i < n; i++)
                if (arr[i] > mx)
                    mx = arr[i];
            return mx;
        }

        public void CountSort(SortingArray arr, int n, int exp)
        {
            int[] output = new int[n]; 
            int i;
            int[] count = new int[10];

            for (i = 0; i < 10; i++)
                count[i] = 0;

            for (i = 0; i < n; i++)
                count[(arr[i] / exp) % 10]++;


            for (i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (i = n - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
            }
            

            for (i = 0; i < n; i++)
                arr[i] = output[i];
        }

        public override void Sorting(SortingArray arr)
        {
            int m = GetMax(arr, arr.Length);

            for (int exp = 1; m / exp > 0; exp *= 10)
                CountSort(arr, arr.Length, exp);
        }
    }
}
