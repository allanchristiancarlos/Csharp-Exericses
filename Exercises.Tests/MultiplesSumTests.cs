using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises.MultiplesSum;

namespace Exercises.Tests
{
    [TestClass]
    public class MultiplesSumTests
    {
        [TestMethod]
        public void Should_get_the_multiples_of_a_number()
        {
            var max = 10;
            var expectedList = new List<int>() {3,6,9};
            var gotList = MultiplesSum.MultiplesSum.GetNumberMultiples(3, max);

            // Compare list
            var firstNotSecond = expectedList.Except(gotList).ToList();
            var secondNotFirst = gotList.Except(expectedList).ToList();

            Assert.IsTrue(!firstNotSecond.Any() && !secondNotFirst.Any());
        }

        [TestMethod]
        public void Should_get_the_sum_of_multiples_of_3_and_5_below_10()
        {
            var sum = MultiplesSum.MultiplesSum.GetSumOfMultiples(new List<int> {3, 5}, 10);

            Assert.AreEqual(23, sum);
        }
        
        [TestMethod]
        public void Should_get_the_sum_of_multiples_of_3_and_5_below_1000()
        {
            var sum = MultiplesSum.MultiplesSum.GetSumOfMultiples(new List<int> { 3, 5 }, 1000);

            Assert.AreEqual(266333, sum);
        }

    }
}
