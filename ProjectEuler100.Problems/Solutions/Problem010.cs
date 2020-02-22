namespace ProjectEuler100.Problems
{
    // Find the sum of all the primes below two million.
    // solution time = 00:00:00.0310676
    public class Problem010
    {
        public long Solve(int upper)
        {
            return SumPrimes(upper);
        }

        private long SumPrimes(int upper)
        {
            var primes = new ProjectEuler100.Utils.EulerTools().AllPrimesLessThan(upper);

            long sum = 0;
            for (int i = 0; i < primes.Count; i++)
            {
                sum += primes[i];
            }

            return sum;
        }
    }
}
