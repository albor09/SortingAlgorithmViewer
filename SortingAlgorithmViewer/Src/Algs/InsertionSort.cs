﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmViewer.Src.Algs
{
    internal class InsertionSort : Algorithm
    {
        public override void Sorting(SortingArray arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}
