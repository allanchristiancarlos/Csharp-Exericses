﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class LargestPrimeFactorTests
    {
        [TestMethod]
        public void Should_check_if_number_is_prime_number()
        {
            Assert.IsTrue(LargestPrimeFactor.LargestPrimeFactor.IsPrimeNumber(11));
        }

        [TestMethod]
        public void Should_get_the_prime_factors_of_a_number()
        {
            var expected = new List<long>() { 71, 839, 1471, 6857 };
            List<long> actual = LargestPrimeFactor.LargestPrimeFactor.GetPrimeFactors(600851475143);

            foreach (var i in actual)
            {
                Assert.IsTrue(LargestPrimeFactor.LargestPrimeFactor.IsPrimeNumber(i));
                Console.WriteLine($"number: {i}");
            }


            var first = expected.Except(actual).ToList();
            var second = actual.Except(expected).ToList();

            Assert.IsTrue(!first.Any() && !second.Any());
        }
    }
}