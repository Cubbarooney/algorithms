using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.Sorting;
using System.Linq;

namespace AlgorithmsUnitTests.Sorting
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        public void BubbleSort_SimpleCase()
        {
            var inputArray = new int[] { 4, 6, 3, 5, 7, 0, 8, 1, 9, 2 };
            var expectedArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            RunBubbleSortTest(expectedArray, inputArray);
        }

        [TestMethod]
        public void BubbleSort_SortedList()
        {
            var inputArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var expectedArray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            RunBubbleSortTest(expectedArray, inputArray);
        }

        [TestMethod]
        public void BubbleSort_EmptyList()
        {
            var inputArray = new int[] { };
            var expectedArray = new int[] { };
            RunBubbleSortTest(expectedArray, inputArray);
        }

        [TestMethod]
        public void BubbleSort_SingletonList()
        {
            var inputArray = new int[] { 21 };
            var expectedArray = new int[] { 21 };
            RunBubbleSortTest(expectedArray, inputArray);
        }
        
        private void RunBubbleSortTest<T>(IList<T> expectedArray, IList<T> inputArray) where T : IComparable
        {
            inputArray.DoBubbleSort();

            var result = inputArray.SequenceEqual(expectedArray);
            Assert.IsTrue(result);
        }
    }
}
