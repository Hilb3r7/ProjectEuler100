using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler100.Problems
{
    // Evaluate the sum of all the amicable numbers under 10000.
    // Solution time = 00:00:00.0240443
    public class Problem021
    {
        public int Solve(int bound)
        {
            return GetAmicableNumbers(bound).Sum();
        }

        private List<int> GetAmicableNumbers(int bound)
        {
            var amicables = new List<int>();
            var tools = new Utils.EulerTools();
            var primes = tools.AllPrimesLessThan(bound);

            for (int n = 2; n < bound; n++)
            {
                int dofn = tools.SumOfProperDivisors(n, primes);
                if (dofn > n && tools.SumOfProperDivisors(dofn, primes) == n)
                {
                    amicables.Add(n);
                    if (dofn < bound) amicables.Add(dofn);
                } 
            }

            return amicables;
        }
    }
}
