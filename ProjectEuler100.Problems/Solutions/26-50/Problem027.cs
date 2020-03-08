using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler100.Problems
{
    // Find the product of the coefficients, a and b, for the quadratic expression that 
    // produces the maximum number of primes for consecutive values of n, starting with n=0.
    // Solution 
    public class Problem027
    {
        public int Solve(int bound)
        {
            var ans = MaximumPrimeGenerator(bound);
            return ans.Item1 * ans.Item2;
        }

        // optimizations I notice, b has to be prime, a has to be odd, the answer can't be larger than
        // b - 1
        private (int, int) MaximumPrimeGenerator(int bound)
        {
            int maxNumPrimes = 0;
            var coEffs = (0, 0);
            var primesUnderBound = new Utils.EulerTools().AllPrimesLessThan(bound);
            var primeCheck = new Utils.EulerTools().AllPrimesLessThan(bound * 10); // random guess thats enough

            for (int i = primesUnderBound.Count - 1;  primesUnderBound[i] > maxNumPrimes; i--)
            {
                int b = primesUnderBound[i];
                for (int a = (bound % 2 == 0)? -bound + 1: -bound; a < bound; a += 2)
                {
                    int numPrimes = GetNumConsecPrimes(a, b, primeCheck);
                    if (numPrimes > maxNumPrimes)
                    {
                        maxNumPrimes = numPrimes;
                        coEffs = (a, b);
                    }
                }
            }

            return coEffs;
        }

        private int GetNumConsecPrimes(int a, int b, List<int> primes)
        {
            int total, n = total = 0;

            while (primes.BinarySearch(n * n + (a * n) + b) >- 0 && n < b )
            {
                total++;
                n++;
            }

            return total;
        }
    }
}
