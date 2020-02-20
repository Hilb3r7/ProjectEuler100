using System;
using System.Collections.Generic;

namespace ProjectEuler100.Problems
{
    // What is the largest prime factor of the number 600851475143 ?
    // solution time = 00:00:00.0085086
    public class Problem003
    {
        public long Solve(long num)
        {
            return LargestPrimeFactor(num, new Utils.EulerTools().AllPrimesLessThan(10000)); // picked 10K figuring it would be big enough
        }

        /* Simple algorithm that takes a list of primes and starting with smallest factors it out of the number
         * you are left with either 1 (the prime you are factoring out evenly divides what is left) or a prime 
         * number (since we only have to check primes up to square root of number if the next prime to check is
         * bigger than square root, then the number must be prime, so it is obviously largest factor)
         */
        private long LargestPrimeFactor(long num, List<int> primes)
        {
            int index = 0;
            while (num > 1 && primes[index] <= Math.Sqrt(num))
            {
                while (num % primes[index] == 0) num /= primes[index];
                index++;
            }

            return (num == 1) ? primes[index - 1] : num; // -1 because we incremented past answer exiting loop
        }
    }
}
