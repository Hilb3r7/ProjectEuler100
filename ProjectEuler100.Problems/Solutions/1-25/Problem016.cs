using System.Linq;
using System.Numerics;

namespace ProjectEuler100.Problems
{
    // What is the sum of the digits of the number 21000?
    // Solution time = 00:00:00.0120740
    public class Problem016
    {
        public int Solve(int power)
        {
            return BigIntegerDigitSum(PowerTwoNaive(power));
        }

        private int BigIntegerDigitSum(BigInteger num)
        {
            return num.ToString().ToCharArray().Sum(x => x - '0');
        }

        // I'm lazy, so just wrote quick loop instead of more efficient exponentiaton
        private BigInteger PowerTwoNaive(int power)
        {
            BigInteger num = new BigInteger(1);
            BigInteger two = new BigInteger(2);

            for (int i = 0; i < power; i++)
            {
                num = BigInteger.Multiply(num, two);
            }

            return num;
        }
    }
}
