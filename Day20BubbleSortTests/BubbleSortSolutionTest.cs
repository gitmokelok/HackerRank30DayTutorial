using System;
using Day20BubbleSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day20BubbleSortTests
{
    [TestClass]
    public class BubbleSortSolutionTest
    {
        [TestMethod]
        public void bubbleSort_returnSortedArray()
        {
            var solution = new BubbleSortSolution();
            var intArray = new int[]{3,2,1};
            solution.bubbleSort(intArray, 3);

            Assert.AreEqual(1, intArray[0]);
            Assert.AreEqual(2, intArray[1]);
            Assert.AreEqual(3, intArray[2]);


        }
    }
}
