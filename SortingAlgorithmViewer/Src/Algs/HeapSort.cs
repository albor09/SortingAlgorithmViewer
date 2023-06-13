using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmViewer.Src.Algs
{
    class HeapSort : Algorithm
    {
        public override void Sorting(SortingArray arr)
        {
            int N = arr.Length;

            for (int i = N / 2 - 1; i >= 0; i--)
                Heapify(arr, N, i);

            for (int i = N - 1; i > 0; i--)
            {
                arr.Swap(i, 0);

                Heapify(arr, i, 0);
            }
        }

        void Heapify(SortingArray arr, int N, int i)
        {
            int largest = i; 
            int l = 2 * i + 1; 
            int r = 2 * i + 2; 

            if (l < N && arr[l] > arr[largest])
                largest = l;

            if (r < N && arr[r] > arr[largest])
                largest = r;

            if (largest != i)
            {
                arr.Swap(i, largest);

                Heapify(arr, N, largest);
            }
        }

    }
}
