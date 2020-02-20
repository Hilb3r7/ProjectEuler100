using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler100.Problems
{
    // Find the sum of all the multiples of 3 or 5 below 1000
    class Problem001
    {
        public int Solve(int bound)
        {
            return SumMultiplesOf(3, bound) + SumMultiplesOf(5, bound) - SumMultiplesOf(3 * 5, bound);
        }

        private int SumMultiplesOf(int factor, int bound)
        {
            var sum = 0;
            for (int i = factor; i < bound; i += factor)
            {
                sum += i;
            }

            return sum;
        }

    }
}
