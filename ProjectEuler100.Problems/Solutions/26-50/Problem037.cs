using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler100.Problems
{
    // Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
    // Solution time = 00:00:00.0208204
    public class Problem037
    {
        public int Solve()
        {
            return GetAllLeftRightTrunctablePrimes().Sum();
        }

        /* Redid the problem after realizing a better solution reading some of the forum comments. A Left/Right
         * truncatable prime has to start with 2,3,5,7 or else it wont be right Truncatable. Then each digit after
         * can only be 1,3,7,9 as no prime > 10 ends in any other digit. However for it to be left truncatalbe it must
         * end in 3 or 7. So we will recursively generate all right truncsatable primes, and then check those that
         * end in 3 or 7 for left truncability. This is how there are only 11 such numbers, because eventually
         * there will be no digit we can add for the number to be right truncatable (so no later number could be 
         * left AND right truncatable
         */
        private List<int> GetAllLeftRightTrunctablePrimes()
        {
            var tools = new Utils.EulerTools();
            var truncatables = new List<int>();

            int[] firstDigits = { 2, 3, 5, 7 };
            foreach (var digit in firstDigits)
            {
                LeftRightTruncatableSearch(digit, tools, truncatables);
            }

            return truncatables;
        }

        private void LeftRightTruncatableSearch(int num, Utils.EulerTools tools, List<int> truncatables)
        {
            if (tools.IsPrime(num))
            {
                int last = num % 10;
                if ((last == 3 || last == 7) && IsLeftTruncatablePrime(num, tools)) truncatables.Add(num);

                num *= 10;
                int[] digits = { 1, 3, 7, 9 };
                foreach (var digit in digits)
                {
                    LeftRightTruncatableSearch(num + digit, tools, truncatables);
                }
            }
        }

        private bool IsLeftTruncatablePrime(int prime, Utils.EulerTools tools)
        {
            if (prime < 10) return false;

            int modulus = (int) Math.Pow(10, Math.Ceiling(Math.Log10(prime)));

            while (modulus > 1)
            {
                if (!tools.IsPrime(prime % modulus)) return false;
                modulus /= 10;
            }

            return true;
        }

    }
}
