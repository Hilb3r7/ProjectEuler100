using System;

namespace ProjectEuler100.Problems
{
    public class Problem002
    {
        // By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
        // find the sum of the even-valued terms.
        public int Solve(int bound)
        {
            var sum = 0;
            var n = 1;
            var Fn = 1;
            while (Fn < bound)
            {
                sum += (Fn % 2 == 0) ? Fn : 0;
                Fn = NthFib(++n);
            }

            return sum;
        }

        private int NthFib(int n)
        {
            double Phi = 1.61803398874989484820458683436;

            return (int) Math.Round(Math.Pow(Phi, n) / Math.Sqrt(5));
        }
    }
}
