using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class EvenFibonacciTests
    {
        [TestMethod]
        public void Should_get_the_sum_of_all_event_numbers_in_fibonacci_number_1_max_of_10_result()
        {
            int sum = EvenFibonacci.EventFibonacci.GetSumOfEvenFibonacciNumbers(1, 10);

            Assert.AreEqual(10, sum);
        }

        [TestMethod]
        public void Should_get_the_sum_of_all_event_numbers_in_fibonacci_number_1_max_of_4000000_result()
        {
            int sum = EvenFibonacci.EventFibonacci.GetSumOfEvenFibonacciNumbers(1, 4000000);

            Assert.AreEqual(4613732, sum);
        }

        [TestMethod]
        public void Should_get_the_fibonacci_numbers_of_a_number()
        {
            var expected = new List<int>() {1,2,3,5,8};
            var actual = EvenFibonacci.EventFibonacci.GetFibonacci(1, 10);

            var first = expected.Except(actual).ToList();
            var second = actual.Except(expected).ToList();

            Assert.IsTrue(!first.Any() && !second.Any());
        }

        [TestMethod]
        public void Should_only_get_even_fibonacci_numbers()
        {
            var expected = new List<int>() { 2, 8 };
            var actual = EvenFibonacci.EventFibonacci.GetEvenFibonacci(1, 10);

            var first = expected.Except(actual).ToList();
            var second = actual.Except(expected).ToList();

            Assert.IsTrue(!first.Any() && !second.Any());
        }
    }
}
