namespace ProjectEuler100.Problems
{
    // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    // solution time = 00:00:00.0003029
    public class Problem006
    {
        public int Solve(int upper)
        {
            int sumFirstN = SumFirstN(upper);

            return sumFirstN * sumFirstN - SumFirstNSquares(upper);
        }

        // Sn = n(n+1) / 2
        private int SumFirstN(int upper)
        {
            return upper * (upper + 1) / 2;
        }

        // n(n+1)(2n+1) / 6
        private int SumFirstNSquares(int upper)
        {
            return upper * (upper + 1) * (2 * upper + 1) / 6;
        }
    }
}
