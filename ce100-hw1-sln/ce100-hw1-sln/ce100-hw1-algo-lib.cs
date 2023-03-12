using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class SelectionSort_Class
    {

        public static void replace(ref int first, ref int second)
        {
            int r = first;

            first = second;
            second = r;
        }

        public static int[] Selectionsort(int[] row, int size)
        {
            int[] result = new int[size];

            for (int j = 0; j < size - 1; j++)
            {
                int min = j;

                for (int i = j + 1; i < size; i++)
                {

                    if (row[i] < row[min])
                        min = i;
                }

                replace(ref row[min], ref row[j]);
            }

            for (int i = 0; i < size; i++)
            {
                result[i] = row[i];
            }

            return result;
        }

    }

    public class MergeSort_Class
    {
        public static void merge(int[] arr, int p, int q, int r)
        {


            int n1 = q - p + 1;
            int n2 = r - q;

            int[] L = new int[n1];
            int[] M = new int[n2];

            for (int z = 0; z < n1; z++)

                L[z] = arr[p + z];

            for (int y = 0; y < n2; y++)
                M[y] = arr[q + 1 + y];


            int i, j, k;
            i = 0;
            j = 0;
            k = p;

            while (i < n1 && j < n2)
            {
                if (L[i] <= M[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = M[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = M[j];
                j++;
                k++;
            }


        }

      

        public static int[] mergeSort(int[] row, int l, int r)
        {
            int size = row.Length;

            int[] result = new int[size];

            if (l < r)
            {

                int m = l + (r - l) / 2;

                mergeSort(row, l, m);
                mergeSort(row, m + 1, r);

                merge(row, l, m, r);
            }

            for (int i = 0; i < size; i++)
            {
                result[i] = row[i];
            }

            return result;
        }

    }
}
