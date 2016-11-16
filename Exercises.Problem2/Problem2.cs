using System.Collections.Generic;
using System.Linq;

namespace Exercises.Problem2
{
    public class Problem2
    {
        public static int GetSumOfEvenFibonacciNumbers(int startNumber, int max)
        {
            return GetEvenFibonacci(startNumber, max).Sum();
        }


        public static List<int> GetFibonacci(int startNumber, int max)
        {
            var numbers = new List<int>();
            var current = startNumber;
            var lastNumber = startNumber;
            var hasFibonacci = startNumber < max;

            numbers.Add(startNumber);

            while (hasFibonacci)
            {
                var tmpCurrent = current;
                current += lastNumber;

                if (current < max)
                {
                    lastNumber = tmpCurrent;
                    numbers.Add(current);
                }
                else
                {
                    hasFibonacci = false;
                }
            }

            return numbers;
        }

        public static List<int> GetEvenFibonacci(int startNumber, int max)
        {
            return GetFibonacci(startNumber, max).Where(n => n % 2 == 0).ToList();
        }
    }
}
