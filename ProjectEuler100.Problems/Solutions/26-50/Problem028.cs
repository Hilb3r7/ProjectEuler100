
namespace ProjectEuler100.Problems
{
    // What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
    // Solution time = 00:00:00.0003436
    public class Problem028
    {
        public int Solve(int n)
        {
            return SumSpiralDiagonals(n);
        }

        private int SumSpiralDiagonals(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return SumOfCorners(n) + SumSpiralDiagonals(n - 2);
        }

        private int SumOfCorners(int n)
        {
            if (n == 1) return 1;

            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += n * n - (n - 1) * i;
            }

            return sum;
        }
    }
}
