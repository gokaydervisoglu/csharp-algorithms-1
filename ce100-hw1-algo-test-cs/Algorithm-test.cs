using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;
using BinarySearch;
using MatrixMultiplication;
using MasterTheroem;
using MathNet.Numerics.LinearAlgebra;



namespace SelectionSort_TestClass
{
    // SelectionSort

    /// <summary>
    /// The purpose of the test here is to sort a nearly complete array and see the best method.
    /// </summary>

    [TestClass]
    public class BestSelectionSortTests
    {
        [TestMethod]
        public void TestSelectionSortMethod()
        {

            int size;

            int[] data2 = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data2.Length; i++)
            {
                data2[i] = random.Next(0, 10000);
            }
            Array.Sort(data2);

            Random random2 = new Random();
            for (int i = 5000; i < data2.Length - 4000; i++)
            {
                data2[i] = random.Next(0, 10000);
            }

            for (int i = 0; i < data2.Length - 5000; i++)
            {
                data2[i] = random.Next(0, 10000);
            }

            size = data2.Length;

            int[] result = SelectionSort_Class.Selectionsort(data2, size);

            int[] expected = (int[])data2.Clone();
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);

        }
    }

    /// <summary>
    /// Our goal here is to correctly sort a randomly sorted string, to see the average method here.
    /// </summary>

    [TestClass]
    public class AverageSelectionSortTests
    {
        [TestMethod]
        public void TestSelectionSortMethod()
        {
            int size;

            int[] data2 = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data2.Length; i++)
            {
                data2[i] = random.Next(0, 10000);
            }

            size = data2.Length;

            int[] result = SelectionSort_Class.Selectionsort(data2, size);

            int[] expected = (int[])data2.Clone();
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);

        }
    }

    /// <summary>
    /// Our goal here is to correctly sort a reverse sorted string, to see the worst method here.
    /// </summary>

    [TestClass]
    public class WorstSelectionSortTests
    {
        [TestMethod]
        public void TestSelectionSortMethod()
        {
            int size;

            int[] data2 = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data2.Length; i++)
            {
                data2[i] = random.Next(0, 10000);
            }

            Array.Sort(data2);
            Array.Reverse(data2);

            size = data2.Length;

            int[] result = SelectionSort_Class.Selectionsort(data2, size);

            int[] expected = (int[])data2.Clone();
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);

        }
    }

}

namespace MergeSort_TestClass
{

    //MergeSort

    /// <summary>
    /// The purpose of the test here is to sort a nearly complete array and see the best method.
    /// </summary>

    [TestClass]
    public class BestMergeShortTests
    {
        [TestMethod]
        public void TestMergeSortMethod()
        {
            int size;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }
            Array.Sort(data);

            Random random2 = new Random();
            for (int i = 5000; i < data.Length - 4000; i++)
            {
                data[i] = random.Next(0, 10000);
            }

            size = data.Length;

            int[] result = MergeSort_Class.mergeSort(data, 0, size - 1);

            int[] expected = (int[])data.Clone();
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);

        }
    }

    /// <summary>
    /// Our goal here is to correctly sort a randomly sorted string, to see the average method here.
    /// </summary>

    [TestClass]
    public class AverageMergeShortTests
    {
        [TestMethod]
        public void TestMergeSortMethod()
        {
            int size;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }

            size = data.Length;

            int[] result = MergeSort_Class.mergeSort(data, 0, size - 1);

            int[] expected = (int[])data.Clone();
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);

        }
    }

    /// <summary>
    /// Our goal here is to correctly sort a reverse sorted string, to see the worst method here.
    /// </summary>

    [TestClass]
    public class WorstMergeShortTests
    {
        [TestMethod]
        public void TestMergeSortMethod()
        {
            int size;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }
            Array.Sort(data);
            Array.Reverse(data);

            size = data.Length;

            int[] result = MergeSort_Class.mergeSort(data, 0, size - 1);

            int[] expected = (int[])data.Clone();
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);

        }
    }
}

namespace QuickShortHoare_TestClass
{

    //QuickShort-Hoare

    /// <summary>
    /// The purpose of the test here is to sort a nearly complete array and see the best method.
    /// </summary>

    [TestClass]
    public class BestQuickSortHoareTests
    {
        [TestMethod]
        public void TestQuickSortHoareMethod()
        {
            int size;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }
            Array.Sort(data);

            Random random2 = new Random();
            for (int i = 5000; i < data.Length - 4000; i++)
            {
                data[i] = random.Next(0, 10000);
            }

            size = data.Length;

            int[] result = QuickSortHoare_Class.quickSort(data, 0, size - 1);

            int[] expected = (int[])data.Clone();
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);

        }
    }

    /// <summary>
    /// Our goal here is to correctly sort a randomly sorted string, to see the average method here.
    /// </summary>

    [TestClass]
    public class AverageQuickSortHoareTests
    {
        [TestMethod]
        public void TestQuickSortHoareMethod()
        {
            int size;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }

            size = data.Length;

            int[] result = QuickSortHoare_Class.quickSort(data, 0, size - 1);

            int[] expected = (int[])data.Clone();
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);

        }
    }

    /// <summary>
    /// Our goal here is to correctly sort a reverse sorted string, to see the worst method here.
    /// </summary>

    [TestClass]
    public class WorstQuickSortHoareTests
    {
        [TestMethod]
        public void TestQuickSortHoareMethod()
        {
            int size;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }
            Array.Sort(data);
            Array.Reverse(data);

            size = data.Length;

            int[] result = QuickSortHoare_Class.quickSort(data, 0, size - 1);

            int[] expected = (int[])data.Clone();
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);

        }
    }

}

namespace QuickShortLomuto_TestClass
{
    //QuickShort-Lomuto

    /// <summary>
    /// The purpose of the test here is to sort a nearly complete array and see the best method.
    /// </summary>

    [TestClass]
    public class BestQuickSortLomutoTests
    {
        [TestMethod]
        public void TestQuickSortLomutoMethod()
        {
            int size;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }
            Array.Sort(data);

            Random random2 = new Random();
            for (int i = 5000; i < data.Length - 4000; i++)
            {
                data[i] = random.Next(0, 10000);
            }

            size = data.Length;

            int[] result = QuickSortLomuto_Class.quickSort(data, 0, size - 1);

            int[] expected = (int[])data.Clone();
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);

        }
    }

    /// <summary>
    /// Our goal here is to correctly sort a randomly sorted string, to see the average method here.
    /// </summary>

    [TestClass]
    public class AverageQuickSortLomutoTests
    {
        [TestMethod]
        public void TestQuickSortLomutoMethod()
        {
            int size;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }

            size = data.Length;

            int[] result = QuickSortLomuto_Class.quickSort(data, 0, size - 1);

            int[] expected = (int[])data.Clone();
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);

        }
    }

    /// <summary>
    /// Our goal here is to correctly sort a reverse sorted string, to see the worst method here.
    /// </summary>

    [TestClass]
    public class WorstQuickSortLomutoTests
    {
        [TestMethod]
        public void TestQuickSortLomutoMethod()
        {
            int size;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }
            Array.Sort(data);
            Array.Reverse(data);

            size = data.Length;

            int[] result = QuickSortLomuto_Class.quickSort(data, 0, size - 1);

            int[] expected = (int[])data.Clone();
            Array.Sort(expected);

            CollectionAssert.AreEqual(expected, result);

        }
    }
}

namespace BinarySearchIterative_TestClass
{
    /// <summary>
    /// For the best scenario, we determined the
    /// number to be searched directly as the middle
    /// element of the string.
    /// </summary>
    [TestClass]
    public class BestbinarySearchIterativeTests
    {
        [TestMethod]
        public void TestIterativeMethod()
        {
            int size;
            int expected = 0;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }

            Random random2 = new Random();

            size = data.Length;

            int[] data2 = (int[])data.Clone();
            Array.Sort(data2);

            int number = data2[5000];

            int result = BinarySearchIterative_Class.binarySearch(data2, number);

            Assert.AreEqual(expected, result);

        }

    }
    /// <summary>
    /// For the average scenario, we determined the
    /// number to be searched as any random element
    /// of the string.
    /// </summary>
    [TestClass]
    public class AveragebinarySearchIterativeTests
    {
        [TestMethod]
        public void TestIterativeMethod()
        {
            int size;
            int expected = 0;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }

            Random numberx = new Random();
            int j = numberx.Next(1, 10000);

            size = data.Length;

            int[] data2 = (int[])data.Clone();
            Array.Sort(data2);

            int number = data2[j];

            int result = BinarySearchIterative_Class.binarySearch(data2, number);

            Assert.AreEqual(expected, result);

        }

    }
    /// <summary>
    /// For the worst case scenario, we determined the
    /// number to be searched as a number that is not
    /// in the array.
    /// </summary>
    [TestClass]
    public class WorstbinarySearchIterativeTests
    {
        [TestMethod]
        public void TestIterativeMethod()
        {
            int size;
            int expected = -1;
            // worst-case scenario no value specified

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }

            size = data.Length;

            int[] data2 = (int[])data.Clone();
            Array.Sort(data2);

            int number = 10001;

            int result = BinarySearchIterative_Class.binarySearch(data2, number);

            Assert.AreEqual(expected, result);

        }

    }

}

namespace BinarySearchRecursive_TestClass
{
    /// <summary>
    /// For the best scenario, we determined the
    /// number to be searched directly as the middle
    /// element of the string.
    /// </summary>
    [TestClass]
    public class BestBinarySearchRecursiveTest
    {
        [TestMethod]
        public void TestRecursiveMethod()
        {
            int size;
            int expected = 0;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }

            size = data.Length;

            int[] data2 = (int[])data.Clone();
            Array.Sort(data2);

            int number = data2[5000];

            int result = BinarySearchRecursive_Class.binarySearch(data2, 0, size - 1, number);

            Assert.AreEqual(expected, result);

        }

    }
    /// <summary>
    /// For the average scenario, we determined the
    /// number to be searched as any random element
    /// of the string.
    /// </summary>
    [TestClass]
    public class AvarageBinarySearchRecursiveTest
    {
        [TestMethod]
        public void TestRecursiveMethod()
        {
            int size;
            int expected = 0;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }

            Random numberx = new Random();
            int j = numberx.Next(1, 10000);

            size = data.Length;

            int[] data2 = (int[])data.Clone();
            Array.Sort(data2);

            int number = data2[j];

            int result = BinarySearchRecursive_Class.binarySearch(data2, 0, size - 1, number);

            Assert.AreEqual(expected, result);

        }

    }
    /// <summary>
    /// For the worst case scenario, we determined the
    /// number to be searched as a number that is not
    /// in the array.
    /// </summary>
    [TestClass]
    public class WorstBinarySearchRecursiveTest
    {
        [TestMethod]
        public void TestRecursiveMethod()
        {
            int size;
            int expected = 0;

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }

            size = data.Length;

            int[] data2 = (int[])data.Clone();
            Array.Sort(data2);

            int number = data2[7500];

            int result = BinarySearchRecursive_Class.binarySearch(data2, 0, size - 1, number);

            Assert.AreEqual(expected, result);

        }

    }
}

namespace Matrix_TestClass
{
    /// <summary>
    /// The accuracy of the multiplications of the matrices prepared here has been tested with a ready-made library and matrix function.
    /// </summary>

    [TestClass]
    public class ItarativeMatrix_TestClass
    {
        [TestMethod]
        public void ItarativeMatrixTest()
        {
            int i, j;

            Random random = new Random();
            double[,] m1 = new double[10, 10];
            double[,] m2 = new double[10, 10];

            int size = 10;

            for (i = 1; i < size; i++)
            {
                for (j = 1; j < size; j++)
                {
                    m1[i, j] = random.Next(0, 10);
                }

            }
            for (i = 1; i < size; i++)
            {
                for (j = 1; j < size; j++)
                {
                    m2[i, j] = random.Next(0, 10);
                }
            }

            double[,] result = ItarativeMatrix_Class.ItarativeMatrixMultiply(m1, m2);

            Matrix<double> max1 = Matrix<double>.Build.DenseOfArray(m1);
            Matrix<double> max2 = Matrix<double>.Build.DenseOfArray(m2);
            Matrix<double> expected = max1 * max2;


            double[,] expectedArray = expected.ToArray();

            CollectionAssert.AreEqual(expectedArray, result);

        }

    }

    /// <summary>
    /// The accuracy of the multiplications of the matrices prepared here has been tested with a ready-made library and matrix function.
    /// </summary>

    [TestClass]
    public class RecursiveMatrix_TestClass
    {
        [TestMethod]
        public void RecMatrixTest()
        {
            int i, j;

            Random random = new Random();
            int[,] m1 = new int[10, 10];
            int[,] m2 = new int[10, 10];


            int size = 10;

            for (i = 1; i < size; i++)
            {
                for (j = 1; j < size; j++)
                {
                    m1[i, j] = random.Next(0, 10);
                }

            }
            for (i = 1; i < size; i++)
            {
                for (j = 1; j < size; j++)
                {
                    m2[i, j] = random.Next(0, 10);
                }
            }

            int r1 = m1.GetLength(0);
            int c1 = m1.GetLength(1);

            int r2 = m2.GetLength(0);
            int c2 = m2.GetLength(1);


            int[,] result = RecursiveMatrix_Class.RecursiveMatrixMultiply(m1, m2, r1, c2);

            int[,] expectedArray = new int[m1.GetLength(0), m2.GetLength(1)];

            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    int sum = 0;

                    for (int k = 0; k < size; k++)
                    {
                        sum += m1[i, k] * m2[k, j];
                    }

                    expectedArray[i, j] = sum;
                }
            }

            CollectionAssert.AreEqual(expectedArray, result);

        }

    }

    /// <summary>
    /// The accuracy of the multiplications of the matrices prepared here has been tested with a ready-made library and matrix function.
    /// </summary>

    [TestClass]
    public class StrassenMatrix_TestClass
    {
        [TestMethod]
        public void StrassenMatrixTest()
        {
            int i, j;

            int size = 8;

            Random random = new Random();
            int[,] m1 = new int[size, size];
            int[,] m2 = new int[size, size];


            for (i = 1; i < size; i++)
            {
                for (j = 1; j < size; j++)
                {
                    m1[i, j] = random.Next(0, 10);
                }

            }
            for (i = 1; i < size; i++)
            {
                for (j = 1; j < size; j++)
                {
                    m2[i, j] = random.Next(0, 10);
                }
            }

            int r1 = m1.GetLength(0);
            int c1 = m1.GetLength(1);

            int r2 = m2.GetLength(0);
            int c2 = m2.GetLength(1);


            int[,] result = StrassenMatrix_Class.StrassenMatrixMultiply(m1, m2);

            int[,] expectedArray = new int[m1.GetLength(0), m2.GetLength(1)];

            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    int sum = 0;

                    for (int k = 0; k < size; k++)
                    {
                        sum += m1[i, k] * m2[k, j];
                    }

                    expectedArray[i, j] = sum;
                }
            }

            CollectionAssert.AreEqual(expectedArray, result);

        }

    }
}

namespace MasterTheorem_TestClass
{
    [TestClass]
    public class MasterTheoremTests
    {
        /// <summary>
        /// Here, with the master theorem, the time complexity of 
        /// the functions in the assignment was tested according to the scenarios, 
        /// and the unit tests were verified according to the accuracy of the results equations.
        /// </summary>

        [TestMethod]
        public void MasterTheoremTest3()
        {
            Assert.AreEqual("O(n log n)", MasterTheorem.TimeComplexity(2, 2, 1)); //merge sort Average,Best,Worst
            Assert.AreEqual("O(1)", MasterTheorem.TimeComplexity(1, 2, 1)); //Binary Best 
            Assert.AreEqual("O(n log n)", MasterTheorem.TimeComplexity(2, 2, 1)); // Binary Average,Worst 
            Assert.AreEqual("O(n log n)", MasterTheorem.TimeComplexity(2, 2, 1)); // Quick sort Average,Best

        }

    }
}