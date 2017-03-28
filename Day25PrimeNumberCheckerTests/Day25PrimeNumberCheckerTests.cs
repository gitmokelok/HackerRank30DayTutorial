using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day25PrimeNumbers;

namespace Day25PrimeNumberCheckerTests
{
    [TestClass]
    public class Day25PrimeNumberCheckerTests
    {
        [TestMethod]
        public void PrimeNumberChecker_IsPrime_Zero()
        {
            Assert.IsFalse(PrimeNumberChecker.IsPrime(0));


        }

        [TestMethod]
        public void PrimeNumberChecker_IsPrime_One()
        {
            Assert.IsFalse(PrimeNumberChecker.IsPrime(1));
        }

        [TestMethod]
        public void PrimeNumberChecker_IsPrime_Two()
        {
            Assert.IsTrue(PrimeNumberChecker.IsPrime(2));
        }

        [TestMethod]
        public void PrimeNumberChecker_IsPrime_Three()
        {
            Assert.IsTrue(PrimeNumberChecker.IsPrime(3));
        }

        [TestMethod]
        public void PrimeNumberChecker_IsPrime_4()
        {
            Assert.IsFalse(PrimeNumberChecker.IsPrime(4));
        }
        [TestMethod]
        public void PrimeNumberChecker_IsPrime_5()
        {
            Assert.IsTrue(PrimeNumberChecker.IsPrime(5));
        }
    }
}
