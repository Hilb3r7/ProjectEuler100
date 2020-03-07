using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler100.Problems
{
    // What is the index of the first term in the Fibonacci sequence to contain 1000 digits?
    // Solution time = 00:00:00.0002928
    public class Problem025
    {
        public int Solve(int digits)
        {
            return TermForFirstNthDigitFib(digits);
        }

        // The first n digit fib is this first fib > 10^(n-1). We can use Binet's formula
        // and solve which gives us x > (n + log_10(5) / 2) / log_10(phi)
        public int TermForFirstNthDigitFib(int digits)
        {
            double phi = 1.6180339887;

            return (int) Math.Ceiling(((digits - 1) + Math.Log10(5) / 2) / Math.Log10(phi));
        }
    }
}
