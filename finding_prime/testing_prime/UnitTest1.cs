using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using finding_prime;
namespace testing_prime
{
    [TestClass]
    public class FindingPrime
    {
        [TestMethod]
        public void IsPrimeTrueFor2()
        {
            Assert.AreEqual(true, Program.IsPrime(2));
        }
    }
}
