using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day24RemoveDuplicates;

namespace Day24RemoveDuplicatesTests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void RemoveDuplicates()
        {
            Day24RemoveDuplicates.Solution solution = new Solution();

            var arrayOfInts = new int[6] {1, 2, 2, 3, 3, 4};
            Node head = null;
            int T = arrayOfInts.Length;
            foreach (var i in arrayOfInts)
            {
                head = Solution.insert(head, i);
            }
            head = Solution.removeDuplicates(head);
            Solution.display(head);
        }

        [TestMethod]
        public void RemoveDuplicates_arrayOf20Ints()
        {
            Solution solution = new Solution();

            var arrayOfInts = new int[20] { 3, 9,9,11,11,11,11,89,89,
                                            100,100,101,102,103,108,
                                            200,250,250,250,250 };
            Node head = null;
            int T = arrayOfInts.Length;
            foreach (var i in arrayOfInts)
            {
                head = Solution.insert(head, i);
            }
            head = Solution.removeDuplicates(head);
            Solution.display(head);
        }
        
    }
}
