using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Problem7Tests
    {
        [TestMethod]
        public void Should_get_the_prime_number_at_10001_position()
        {
            Assert.AreEqual(104729, Problem3.Problem3.GetPrimeNumberAtPosition(10001));
        }
    }
}
