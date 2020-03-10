using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler100.Problems
{
    // Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
    // Solution time = 00:00:00.0168388
    public class Problem030
    {
        public int Solve(int power)
        {
            return SumOfAllNPowerDigitSums(power);
        }

        private int SumOfAllNPowerDigitSums(int power)
        {
            var powers = GetPowerArrary(power);
            var sums = new HashSet<int>();

            GetAllPossibleSums(0, powers, 6, 0, sums); // 6 digits is all thats needed for fifth powers or lower

            return sums.Where(x => IsNPowerDigitSum(x, powers)).Sum() - 1; // we don't want 1
        }

        /* This is badically a "stars and bars" combinatorial problem, so we don't have to check
         * every number, only the numbers that are potential sums. This recursively gets those and
         * adds them to a set
         */
        private void GetAllPossibleSums(int index, int[] powers, int numDigits, int sum, HashSet<int> sums)
        {
            if (numDigits == 0) sums.Add(sum);
            else if (index == powers.Length - 1)
            {
                sum += powers[index] * numDigits;
                sums.Add(sum);
            }
            else
            {
                for (int i = numDigits; i >= 0; i--)
                {
                    int tmp = sum + powers[index] * i;
                    GetAllPossibleSums(index + 1, powers, numDigits - i, tmp, sums);
                }
            }
        }

        private bool IsNPowerDigitSum(int sum, int[] powers)
        {
            return sum == sum.ToString().ToCharArray().Sum(x => powers[x - '0']);
        }

        private int[] GetPowerArrary(int power)
        {
            int[] powers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                powers[i] = (int)Math.Pow(i, power);
            }

            return powers;
        }
    }
}
