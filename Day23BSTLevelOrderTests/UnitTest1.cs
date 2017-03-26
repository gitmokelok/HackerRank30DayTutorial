using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day23BSTLevelOrder;


namespace Day23BSTLevelOrderTests
{
    [TestClass]
    public class BstSolutionTest
    {
        [TestMethod]
        public void levelOrder()
        {
            Node root = null;

            //var intArray = new int[] { 3, 5, 4, 7, 2, 1 };
            var intArray = new int[] { 20, 50, 35, 44, 9, 15, 62, 11, 13 };
            foreach (var item in intArray)
            {
                root = BSTSolution.insert(root, item);
            }

            BSTSolution.levelOrder(root);

            //Assert.Output("3 2 5 1 4 7 ", result);
        }
    }
}
