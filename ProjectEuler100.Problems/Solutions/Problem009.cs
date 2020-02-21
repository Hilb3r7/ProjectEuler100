using System.Collections.Generic;

namespace ProjectEuler100.Problems
{
    // There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    // Find the product abc.
    // solution time = 00:00:00.0060500
    public class Problem009
    {
        public int Solve(int sum)
        {
            var abc = GetABC(sum);

            return abc[0] * abc[1] * abc[2];
        }

        /* from famous formula, a = m^2 - n^2, b = 2mn, c = m^2 + n^2
        * where m > n > 0. With a + b + c = sum, we derive
        * m(m+n) = sum/2
        */
        private List<int> GetMandN(int sum)
        {
            var mn = new List<int>();
            sum /= 2;

            for (int m = 2; sum / m > m ; m++)
            {
                if (sum % m == 0)
                {
                    int temp = sum / m;
                    int n = temp - m;
                    if( m > n)
                    {
                        mn.Add(m);
                        mn.Add(n);
                    }
                }
            }

            return mn;
        }

        private List<int> GetABC(int sum)
        {
            var abc = new List<int>();
            var mn = GetMandN(sum); // No error checking for a valid sum happens
            int m = mn[0];
            int n = mn[1];
            abc.Add((m * m) - (n * n));
            abc.Add(2 * m * n);
            abc.Add((m * m) + (n * n));

            return abc;
        }
    }
}
