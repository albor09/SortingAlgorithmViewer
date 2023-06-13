using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmViewer.Src
{
    internal class SortingArray
    {
        public int Length { get { return arr.Length; } }

        private int[] arr;
        private SortingViewer sortingViewer;


        public SortingArray(int length, ArrayGenerationType generationType, SortingViewer sortingViewer)
        {
            this.sortingViewer = sortingViewer;
            if (generationType == ArrayGenerationType.ShuffleIncrease)
                arr = Helper.GenerateArray(length);
        }

        public int this[int index]
        {
            get
            {
                sortingViewer.Highlight(index);
                return arr[index];
            }
            set 
            {
                arr[index] = value;
                sortingViewer.Highlight(index);
            }
        }
        public void Swap(int a, int b)
        {
            sortingViewer.Highlight(a, b);
            int tmp = arr[a];
            arr[a] = arr[b];
            arr[b] = tmp;
            sortingViewer.Highlight(a, b);
        }

        public int[] GetUnwrappedArray()
        {
            return arr;
        }

        public void CheckArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                List<int> h = new List<int>() { };
                for (int j = 0; j <= i; j++)
                {
                    h.Add(j);
                }
                sortingViewer.Highlight(h.ToArray());
            }
        }
    }

    public enum ArrayGenerationType
    {
        ShuffleIncrease,
    }
}


