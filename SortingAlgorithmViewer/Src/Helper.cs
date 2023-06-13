using SortingAlgorithmViewer.Src.Algs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmViewer.Src
{
    internal class Helper
    {
        public static int[] GenerateRndArray(int min, int max, int count)
        {
            Random r = new Random();
            int[] arr = new int[count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(min, max);
            }
            return arr;
        }

        public static int[] GenerateArray(int count)
        {
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = i + 1;
            }
            Shuffle(arr);
            return arr;
        }

        public static void Shuffle<T>(T[] array)
        {
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        public static Algorithm AlgByIndex(int index) 
        {
            switch (index)
            {
                case (0):
                    return new BubbleSort();
                case (1):
                    return new HeapSort();
                case (2):
                    return new InsertionSort();
                case (3):
                    return new QuickSort();
                case (4):
                    return new RadixSort();
                default:
                    return new BubbleSort();
            }
        }
    }
}
