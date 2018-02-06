using Algorithms.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsUnitTests.Sorting
{
    [TestClass]
    public class UtilityTests
    {
        [TestMethod]
        public void SwapTest_OneSwap()
        {
            var array = new int[] { 4, 6, 3, 5, 7, 0, 8, 1, 9, 2 };
            var expectedArray = new int[] { 4, 6, 3, 5, 7, 8, 0, 1, 9, 2 };

            array.Swap(5, 6);

            var result = array.SequenceEqual(expectedArray);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SwapTest_SamePlaceSwap()
        {
            var array = new int[] { 4, 6, 3, 5, 7, 0, 8, 1, 9, 2 };
            var expectedArray = new int[] { 4, 6, 3, 5, 7, 0, 8, 1, 9, 2 };

            array.Swap(5, 5);

            var result = array.SequenceEqual(expectedArray);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void SwapTest_MultiSwap()
        {
            var array = new int[] { 4, 6, 3, 5, 7, 0, 8, 1, 9, 2 };
            var expectedArray = new int[] { 9, 6, 7, 5, 3, 0, 1, 8, 2, 4 };

            array.Swap(1, 5);
            array.Swap(5, 6);
            array.Swap(9, 8);
            array.Swap(5, 7);
            array.Swap(2, 4);
            array.Swap(0, 9);
            array.Swap(5, 6);
            array.Swap(5, 1);

            var result = array.SequenceEqual(expectedArray);
            Assert.IsTrue(result);
        }
    }
}
