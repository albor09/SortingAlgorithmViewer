using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmViewer.Src.Algs
{
    class BubbleSort : Algorithm
    {
        public override void Sorting(SortingArray arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        arr.Swap(j, j + 1);
                    }
                }
            }
        }
    }
}
