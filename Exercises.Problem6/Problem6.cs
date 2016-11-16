using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Problem6
{
    public class Problem6
    {
        public static int SumOfSquaresBetween(int startNumber, int endNumber)
        {
            var sum = 0;
            var currentNumber = startNumber;

            while (endNumber >= currentNumber)
            {
                sum += (currentNumber*currentNumber);
                currentNumber++;
            }

            return sum;
        }

        public static int SquareSumOfNumbersBetween(int startNumber, int endNumber)
        {
            var sum = 0;
            var currentNumber = startNumber;

            while (endNumber >= currentNumber)
            {
                sum += currentNumber;
                currentNumber++;
            }

            return sum * sum;
        }
    }
}
