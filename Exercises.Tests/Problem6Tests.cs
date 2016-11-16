using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Problem6Tests
    {
        [TestMethod]
        public void Should_get_the_sum_of_squares_from_1_to_10()
        {
            var expected = 385;
            int actual = Problem6.Problem6.SumOfSquaresBetween(1, 10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_get_the_square_of_the_sum_of_numbers_from_1_to_10()
        {
            var expected = 3025;
            int actual = Problem6.Problem6.SquareSumOfNumbersBetween(1, 10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_get_the_difference_between_the_square_and_sum_of_first_10_numbers()
        {
            Assert.AreEqual(2640, (Problem6.Problem6.SquareSumOfNumbersBetween(1, 10) - Problem6.Problem6.SumOfSquaresBetween(1, 10)));
        }

        [TestMethod]
        public void Should_get_the_difference_between_the_square_and_sum_of_first_100_numbers()
        {
            Assert.AreEqual(25164150, (Problem6.Problem6.SquareSumOfNumbersBetween(1, 100) - Problem6.Problem6.SumOfSquaresBetween(1, 100)));
        }
    }
}
