using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class SelectionSort_Class
    {

        /// <summary>
        /// Thanks to this function, it serves to replace the elements 
        /// determined in the number sequence with the bridge operation.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        
        public static void replace(ref int first, ref int second)
        {
            int r = first;

            first = second;
            second = r;
        }

        /// <summary>
        /// Selection Sort Method to sort a mixed array.
        /// Initially it tries to make the first row element the 
        /// smallest element of the string.
        /// As usage, it finds the smallest number of the string 
        /// and puts it first in order.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        
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
        /// <summary>
        /// Thanks to this function, it is also indicated in 
        /// the complexity of the strings that are divided 
        /// in the number sequence, 
        /// from n to n/2, to combine them again.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <param name="r"></param>
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

        /// <summary>
        /// The Merge Sort function generally follows the divide-and-conquer method, so it easily sorts tangled large strings neatly.
        /// When we look at the parameters, 
        /// we first determine the middle of the string with the parameters including the beginning and the end of the string to separate n/2 from n.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>

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
        /// <summary>
        /// The partition method performs an operation that divides 
        /// the array elements into two groups based on a particular element. 
        /// Here, the first element on the left is selected as the pivot. 
        /// Next, the elements on the left and right sides are scanned 
        /// sequentially and swapped according to the pivot value. This 
        /// will center the array and return the pivot index.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
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
        /// <summary>
        /// In the QuickSort method, an element in the middle of 
        /// the array is selected and the smaller ones are placed 
        /// on the left and the larger ones on the right. Then the 
        /// QuickSort method is called again for each substring.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Swap method swaps two elements.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void swap(int[] array, int i, int j)
        {

            int temp = array[i];

            array[i] = array[j];

            array[j] = temp;
        }
        /// <summary>
        /// The partition method performs an operation that divides 
        /// the array elements into two groups based on a particular element. 
        /// Here, the last element on the right is selected as the pivot. 
        /// Then the left and right side elements are scanned sequentially 
        /// and swapped according to the pivot value. This will center the 
        /// array and return the pivot index.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
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
        /// <summary>
        /// The QuickSort method selects an element in the middle 
        /// of the array and places the smaller ones on the left 
        /// and the larger ones on the right. Then the QuickSort 
        /// method is called again for each substring.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
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
        /// <summary>
        /// The algorithm divides the range in the middle 
        /// and halves it to the left or right depending on 
        /// whether the searched item is less than or greater 
        /// than the middle item. This process is repeated until 
        /// the searched item is found or the range is exhausted.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="x"></param>
        /// <returns></returns>
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
        /// <summary>
        /// The algorithm divides the range in the middle and halves it 
        /// to the left or right depending on whether the searched item 
        /// is less than or greater than the middle item. This process is 
        /// repeated until the searched item is found or the range is exhausted.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="x"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Iterative Matrix Multiplication is simpler than other methods, so the more inputs, the more difficult it is.
        ///With simple logic, it multiplies and multiplies the row columns of the two matrixes in the form of a loop and is transferred to the newly created matrix at the same level.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        
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
        /// <summary>
        /// Recursive Matrix Multiplication is more useful than other methods, so it can perform loaded operations faster.
        /// Initially, it takes the A and B matrix values, and also the C matrix to be transferred.Thanks to the initial i, j, k values, it breaks the matrices and multiplies them faster.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="k"></param>
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

        /// <summary>
        /// At this stage, the product value of the matrices is transferred to the newly created C matrix. 
        /// In addition, the C matrix is cleaned from the beginning with the loop in order to prevent errors.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="r1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>

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

    public static class StrassenMatrix_Class
    {

        public static int[,] StrassenMatrixMultiply(int[,] m1, int[,] m2)
        {

            int r = m1.GetLength(0);


            int[,] result = new int[r, r];


            if (r == 1)
            {
                result[0, 0] = m1[0, 0] * m2[0, 0];
            }

            else
            {

                int newSize = r / 2;

                int[,] split111 = new int[newSize, newSize];
                int[,] split112 = new int[newSize, newSize];
                int[,] split121 = new int[newSize, newSize];
                int[,] split122 = new int[newSize, newSize];

                int[,] split211 = new int[newSize, newSize];
                int[,] split212 = new int[newSize, newSize];
                int[,] split221 = new int[newSize, newSize];
                int[,] split222 = new int[newSize, newSize];

                Divide(m1, split111, 0, 0);
                Divide(m1, split112, 0, newSize);
                Divide(m1, split121, newSize, 0);
                Divide(m1, split122, newSize, newSize);

                Divide(m2, split211, 0, 0);
                Divide(m2, split212, 0, newSize);
                Divide(m2, split221, newSize, 0);
                Divide(m2, split222, newSize, newSize);


                int[,] p1 = StrassenMatrixMultiply(Add(split111, split122), Add(split211, split222));
                int[,] p2 = StrassenMatrixMultiply(Add(split121, split122), split211);
                int[,] p3 = StrassenMatrixMultiply(split111, untract(split212, split222));
                int[,] p4 = StrassenMatrixMultiply(split122, untract(split221, split211));
                int[,] p5 = StrassenMatrixMultiply(Add(split111, split112), split222);
                int[,] p6 = StrassenMatrixMultiply(untract(split121, split111), Add(split211, split212));
                int[,] p7 = StrassenMatrixMultiply(untract(split112, split122), Add(split221, split222));


                int[,] unresult11 = Add(untract(Add(p1, p4), p5), p7);
                int[,] unresult12 = Add(p3, p5);
                int[,] unresult21 = Add(p2, p4);
                int[,] unresult22 = Add(untract(Add(p1, p3), p2), p6);


                Merge(unresult11, result, 0, 0);
                Merge(unresult12, result, 0, newSize);
                Merge(unresult21, result, newSize, 0);
                Merge(unresult22, result, newSize, newSize);
            }

            return result;
        }
     
        public static int[,] Add(int[,] m1, int[,] m2)
        {
            int n = m1.GetLength(0);
            int[,] result = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }

            return result;
        }
       
        public static int[,] untract(int[,] m1, int[,] m2)
        {
            int r = m1.GetLength(0);
            int[,] result = new int[r, r];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }

            return result;
        }
      
        public static void Divide(int[,] MainMatrix, int[,] OtherMatrix, int rStart, int cStart)
        {
            for (int i = 0, i2 = rStart; i < OtherMatrix.GetLength(0); i++, i2++)
            {
                for (int j = 0, j2 = cStart; j < OtherMatrix.GetLength(1); j++, j2++)
                {
                    OtherMatrix[i, j] = MainMatrix[i2, j2];
                }
            }
        }
       
        public static void Merge(int[,] OtherMatrix, int[,] MainMatrix, int rStart, int cStart)
        {
            for (int i = 0, i2 = rStart; i < OtherMatrix.GetLength(0); i++, i2++)
            {
                for (int j = 0, j2 = cStart; j < OtherMatrix.GetLength(1); j++, j2++)
                {
                    MainMatrix[i2, j2] = OtherMatrix[i, j];
                }
            }
        }

    }
}