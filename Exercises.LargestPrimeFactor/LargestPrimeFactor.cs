using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.LargestPrimeFactor
{
    public class LargestPrimeFactor
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
                if (number%i == 0 && i != 1)
                {
                    return false;
                }
            }

            return true;
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

                result = result/currentNumber; 

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
    }
}
