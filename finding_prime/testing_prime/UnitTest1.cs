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
        [TestMethod]
        public void IsPrimeFalseFor20()
        {
            Assert.AreEqual(false, Program.IsPrime(20));
        }
        [TestMethod]
        public void IsPrimeFalseForMillion()
        {
            Assert.AreEqual(false, Program.IsPrime(1000000));
        }
        [TestMethod]
        public void IsPrimeFalseForNegative1()
        {
            Assert.AreEqual(false, Program.IsPrime(-1));
        }

    }

}
