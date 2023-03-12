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

}
