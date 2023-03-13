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

    public class QuickSortHoare_Class
    {
        public static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[low];
            int i = low - 1, j = high + 1;

            while (true)
            {

                do
                {
                    i++;
                } while (arr[i] < pivot);


                do
                {
                    j--;
                } while (arr[j] > pivot);


                if (i >= j)
                    return j;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;

            }
        }

        public static int[] quickSort(int[] arr, int low, int high)
        {
            int size = arr.Length;

            int[] result = new int[size];


            if (low < high)
            {

                int pivot = partition(arr, low, high);

                quickSort(arr, low, pivot);
                quickSort(arr, pivot + 1, high);
            }

            for (int i = 0; i < size; i++)
            {
                result[i] = arr[i];
            }

            return result;

        }



    }

    public static class QuickSortLomuto_Class
    {
        
        public static void swap(int[] array, int i, int j)
        {

            int temp = array[i];

            array[i] = array[j];

            array[j] = temp;
        }
      
        public static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {

                if (arr[j] <= pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }
     
        public static int[] quickSort(int[] arr, int low, int high)

        {
            int size = arr.Length;

            int[] result = new int[size];

            if (low < high)
            {

                int pivot = partition(arr, low, high);

                quickSort(arr, low, pivot - 1);
                quickSort(arr, pivot + 1, high);
            }

            for (int i = 0; i < size; i++)
            {
                result[i] = arr[i];
            }

            return result;
        }

    }
}

namespace BinarySearch
{
    public static class BinarySearchIterative_Class
    {
        public static int binarySearch(int[] arr, int x)
        {
            int min = 0;
            int max = arr.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (x == arr[mid])
                {
                    return 0;
                }
                else if (x < arr[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return -1;
        }


    }

    public static class BinarySearchRecursive_Class
    {
     
        public static int binarySearch(int[] arr, int left, int right, int x)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == x)
                    return 0;

                if (arr[mid] > x)
                    return binarySearch(arr, left, mid - 1, x);


                return binarySearch(arr, mid + 1, right, x);
            }

            return -1;
        }

    }
}

namespace MatrixMultiplication
{
    public static class ItarativeMatrix_Class
    {
        public static double[,] ItarativeMatrixMultiply(double[,] m1, double[,] m2)
        {

            double[,] result = new double[m1.GetLength(0), m2.GetLength(1)];

            for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    double sum = 0;

                    for (int k = 0; k < m1.GetLength(1); k++)
                    {
                        sum += m1[i, k] * m2[k, j];
                    }

                    result[i, j] = sum;
                }
            }

            return result;
        }
    }

    public static class RecursiveMatrix_Class
    {

        public static void MultiplyMatrix(int[,] A, int[,] B, int[,] C, int i, int j, int k)
        {
            int r1 = A.GetLength(0);
            int c1 = A.GetLength(1);

            int r2 = B.GetLength(0);
            int c2 = B.GetLength(1);

            if (i >= r1)
            {
                return;
            }

            if (j < c2)
            {
                int sum = 0;
                for (k = 0; k < c1; k++)
                {
                    sum += A[i, k] * B[k, j];
                }
                C[i, j] = sum;

                MultiplyMatrix(A, B, C, i, j + 1, 0);
            }
            else
            {
                MultiplyMatrix(A, B, C, i + 1, 0, 0);
            }
        }

        public static int[,] RecursiveMatrixMultiply(int[,] A, int[,] B, int r1, int c2)
        {

            int[,] C = new int[r1, c2];


            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    C[i, j] = 0;
                }
            }

            MultiplyMatrix(A, B, C, 0, 0, 0);

            return C;
        }

    }
}