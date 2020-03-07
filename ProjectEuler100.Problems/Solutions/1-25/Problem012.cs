namespace ProjectEuler100.Problems
{
    // What is the value of the first triangle number to have over five hundred divisors?
    // Solution time = 00:00:00.9816026
    public class Problem012
    {
        public int Solve(int numDivisors)
        {
            return FirstTriangleNumDivsGreaterThan(numDivisors);
        }

        /* Triangle nums are of form T_n = n(n + 1) / 2
         * and the numDivisors function is multiplicative
         */
        private int FirstTriangleNumDivsGreaterThan(int bound)
        {
            int numDivs, n = 1;

            do
            {
                n++;
                numDivs = (n % 2 == 0)?
                    GetNumDivisors(n / 2) * GetNumDivisors(n + 1) :
                    GetNumDivisors(n) * GetNumDivisors((n + 1) / 2);
            } while (numDivs <= bound);

            return n * (n + 1) / 2;
        }

        // n(d) = (a+1)(b+1)(c+1)... where d = (p_1)^a * (p_2)^b * (p_3)^c ...
        private int GetNumDivisors(int num)
        {
            var primes = new Utils.EulerTools().AllPrimesLessThan(5000); // guessing this is enough primes
            int numDivisors = 1;
            int index = 0;

            while (num != 1 &&  primes[index] * primes[index] <= num)
            {
                int power = 0;
                while (num % primes[index] == 0)
                {
                    power++;
                    num /= primes[index];
                }
                if (power != 0) numDivisors *= power + 1;
                index++;
            }

            return (num == 1) ? numDivisors : numDivisors * 2; // num was prime so there's another factor;
        }
    }
}
