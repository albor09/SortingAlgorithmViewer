using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmViewer.Src.Algs
{
    internal class QuickSort : Algorithm
    {
        int partition(SortingArray arr, int low, int high)
        {
            int pivot = arr[high];


            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {

                if (arr[j] < pivot)
                {
                    i++;
                    arr.Swap(i, j);
                }
            }
            arr.Swap(i + 1, high);
            return (i + 1);
        }

        void quickSort(SortingArray arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);

                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }


        public override void Sorting(SortingArray arr)
        {
            int low = 0;
            int high = arr.Length - 1;
            quickSort(arr, low, high);
        }
    }
}
