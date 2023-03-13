using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;
using BinarySearch;
using MatrixMultiplication;


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

            //Random randomx = new Random();
            //int number = randomx.Next(1, 10);

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

            //random number
            //Random randomx = new Random();
            //int number = randomx.Next(1, 5000);


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
            // en kotu senaryo belilenen deger yoktur

            int[] data = new int[10000];
            Random random = new Random();

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = random.Next(0, 10000);
            }

            size = data.Length;

            int[] data2 = (int[])data.Clone();
            Array.Sort(data2);

            //int number = data2[9999];

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