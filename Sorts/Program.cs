using System;

namespace Sorts
{
    class Program
    {
        public static void Display(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void BubbleSort(int[] uarr)
        {
            for (int i = 0; i < uarr.Length; i++)
            {
                for (int j = i + 1; j < uarr.Length; j++)
                {
                    if (uarr[i] > uarr[j])
                    {
                        int tempele = uarr[i];
                        uarr[i] = uarr[j];
                        uarr[j] = tempele;
                    }
                }
            }
            Display(uarr);
        }
        public static void InsertionSort(int[] uarr)
        {
            // [6, 3, 5, 7, 10, 14, 25]
            for (int i = 0; i < uarr.Length; i++)
            {
                for (int j = i; (j > 0 && uarr[j] < uarr[j - 1]); j--)
                {
                    int tempele = uarr[j];
                    uarr[j] = uarr[j - 1];
                    uarr[j - 1] = tempele;
                }
            }
            Display(uarr);
        }

        public static void SelectionSort(int[] arr)
        {
            // [6, 3, 5, 7, 10, 14, 25]
            int i, j, min;
            for (i = 0; i < arr.Length; i++)
            {
                min = i;
                for (j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;
                        Swap(ref arr[i], ref arr[min]);
                    }
                    Console.Write("i = {0}, j = {1}, min = {2} --> ", i, j, min);
                    Display(arr);

                }
            }
            Display(arr);
        }

        public static void QuickSort(int[] uarr)
        {
            // [6, 3, 5, 7, 10, 14, 25]
            for (int i = 0; i < uarr.Length; i++)
            {
                for (int j = i; (j > 0 && uarr[j] < uarr[j - 1]); j--)
                {
                    int tempele = uarr[j];
                    uarr[j] = uarr[j - 1];
                    uarr[j - 1] = tempele;
                }
            }
            Display(uarr);
        }

        static void Main(string[] args)
        {

            Console.WriteLine("-----Bubble Sort-----");
            Display(new int[] { 6, 3, 5, 7, 10, 14, 25 });
            BubbleSort(new int[] { 6, 3, 5, 7, 10, 14, 25 });

            Console.WriteLine("-----Insertion Sort-----");
            Display(new int[] { 6, 3, 5, 7, 10, 14, 25 });
            InsertionSort(new int[] { 6, 3, 5, 7, 10, 14, 25 });

            // Selection sort is similar to Insertion sort
            Console.WriteLine("-----Selection Sort-----");
            //Display(new int[] { 6, 3, 5, 7, 10, 4, 2 });
            SelectionSort(new int[] { 6, 3, 5, 7, 10, 4, 2 });

            //Console.WriteLine("-----Quick Sort-----");
            //Display(new int[] { 6, 3, 5, 7, 10, 14, 25 });
            //QuickSort(new int[] { 6, 3, 5, 7, 10, 14, 25 });

            // Merge sort

        }
    }
}
