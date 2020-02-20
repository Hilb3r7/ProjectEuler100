namespace ProjectEuler100.Problems
{
    // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    // solution time = 00:00:00.0104755
    public class Problem005
    {
        /* Via the Fundamental Theorem of Arithmetic we just need to know the highest power of each prime
         * factor smaller than the upper bound
         */
        public long Solve(int upper)
        {
            return SmallestNumber(upper);
        }

        private long SmallestNumber(int upper)
        {
            long product = 1;
            var primes = new Utils.EulerTools().AllPrimesLessThan(upper);

            foreach (var prime in primes)
            {
                if (prime > upper) break;

                var temp = prime;
                while (temp <= upper)
                {
                    product *= prime;
                    temp *= prime;
                }
            }

            return product;
        }
    }
}
