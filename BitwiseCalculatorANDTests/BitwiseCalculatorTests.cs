using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day29BitwiseAND;

namespace BitwiseCalculatorANDTests
{
    [TestClass]
    public class BitwiseCalculatorTests
    {
        [TestMethod]
        public void BitwiseCalculator_Constructor()
        {
            BitwiseCalculator calc = new BitwiseCalculator(3);
            
            Assert.AreEqual(3, calc.NumberOfTests);
            Assert.IsNotNull(calc.NkPairs);
            Assert.IsNull(calc.ArrayOfInts);
            Assert.IsNull(calc.BitwiseResultsList);
        }


    }
}
