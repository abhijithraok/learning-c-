using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using prime_factors;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class TestingPrimeFactor
    {
        [TestMethod]
        public void Test480()
        {
            int input = 480;
            var expectedResult = new Dictionary<int, int>
            {
                {2, 5 },
                {3, 1 },
                {5 , 1 }
            };

            var calculated = Program.Factor(input);
            Assert.AreEqual(expectedResult, calculated);
        }
    }
}
