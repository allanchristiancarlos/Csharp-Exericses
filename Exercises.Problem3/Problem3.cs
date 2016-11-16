using System.Collections.Generic;
using System.Linq;

namespace Exercises.Problem3
{
    public class Problem3
    {
        public static bool IsPrimeNumber(long number)
        {
            if (number == 2)
            {
                return true;
            }

            if (number == 1)
            {
                return false;
            }

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0 && i != 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static long GetPrimeNumberAtPosition(long position)
        {
            var notYetInPosition = true;
            var currentPosition = 1;
            var currentNumber = 1;

            while (notYetInPosition)
            {
                if (!IsPrimeNumber(currentNumber))
                {
                    currentNumber++;
                    continue;
                }

                currentPosition++;

                if (position == currentPosition)
                {
                    notYetInPosition = false;
                }
                else
                {
                    currentNumber++;
                }
            }

            return currentNumber;
        }

        public static List<long> GetPrimeFactors(long number)
        {
            var currentNumber = 2;
            var isPrime = true;
            var factors = new List<long>();
            var result = number;

            while (isPrime)
            {
                // Check if prime number and is divisible by number
                if (!IsPrimeNumber(currentNumber) || result % currentNumber != 0)
                {
                    currentNumber++;
                    continue;
                }

                result = result / currentNumber;

                // Add the current number cause its a prime number
                factors.Add(currentNumber);

                // Check if the result is a prime number
                if (IsPrimeNumber(result))
                {
                    isPrime = false;
                    factors.Add(result);
                }
            }

            return factors;
        }

        public static long GetLargestPrimeFactor(long number)
        {
            return GetPrimeFactors(number).Max();
        }
    }
}
