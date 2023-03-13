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