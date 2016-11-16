using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Problem3Tests
    {
        [TestMethod]
        public void Should_check_if_number_is_prime_number()
        {
            Assert.IsTrue(Problem3.Problem3.IsPrimeNumber(11));
        }

        [TestMethod]
        public void Should_get_the_prime_factors_of_a_number()
        {
            var expected = new List<long>() { 5,7,13,29 };
            List<long> actual = Problem3.Problem3.GetPrimeFactors(13195);

            foreach (var i in actual)
            {
                Assert.IsTrue(Problem3.Problem3.IsPrimeNumber(i));
                Console.WriteLine($"number: {i}");
            }


            var first = expected.Except(actual).ToList();
            var second = actual.Except(expected).ToList();

            Assert.IsTrue(!first.Any() && !second.Any());
        }

        [TestMethod]
        public void Should_get_the_largest_prime_factor_of_a_number()
        {
            Assert.AreEqual(6857, Problem3.Problem3.GetLargestPrimeFactor(600851475143));
        }
    }
}
