using System.Linq;
using System.Numerics;

namespace ProjectEuler100.Problems
{
    // Find the sum of the digits in the number 100!
    // Solution time = 00:00:00.0154285
    public class Problem020
    {
        public int Solve(int bound)
        {
            return BigIntegerDigitSum(NFactorial(bound));
        }

        private BigInteger NFactorial(int bound)
        {
            var factorial = new BigInteger(1);

            for (int i = bound; i > 1; i--)
            {
                factorial *= i;
            }
            
            return factorial;
        }

        private int BigIntegerDigitSum(BigInteger num)
        {
            return num.ToString().ToCharArray().Sum(x => x - '0');
        }
    }
}
