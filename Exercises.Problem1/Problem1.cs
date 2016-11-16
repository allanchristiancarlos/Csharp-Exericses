using System.Collections.Generic;
using System.Linq;

namespace Exercises.Problem1
{
    public class Problem1
    {
        public static int GetSumOfMultiples(List<int> ints, int below)
        {
            int sum = 0;

            foreach (var number in ints)
            {
                sum += GetNumberMultiples(number, below).Sum();
            }

            return sum;
        }

        public static List<int> GetNumberMultiples(int number, int max)
        {
            var hasMultiple = number < max;
            var list = new List<int>();
            var currentMultiple = number;
            list.Add(number);

            while (hasMultiple)
            {
                currentMultiple += number;

                if (currentMultiple < max)
                {
                    list.Add(currentMultiple);
                }
                else
                {
                    hasMultiple = false;
                }
            }

            return list;
        }
    }
}
