
namespace ProjectEuler100.Problems
{
    // Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
    // Solution time = 00:00:00.0005568
    public class Problem026
    {
        public int Solve(int bound)
        {
            return GetNWithLongestRepetend(bound);
        }

        private int GetNWithLongestRepetend(int bound)
        {
            int longestN, longestRepLength = longestN = 1;

            for (int i = bound; i > longestRepLength; i--) // max repetend length for n is n - 1
            {
                int length = RepetendLength(i);
                if (length > longestRepLength)
                {
                    longestN = i;
                    longestRepLength = length;
                }
            }

            return longestN;
        }

        // https://mathworld.wolfram.com/DecimalExpansion.html for explanation.
        // cliffs: The order of 10 modulo n will return length of repeated decimal for 1/n 
        // when (10, n) = 1.
        private int RepetendLength(int n)
        {
            while (n % 2 == 0) n /= 2;
            while (n % 5 == 0) n /= 5;
            if (n == 1) return 0;

            int t = 0;
            int a = 1;
            do
            {
                a = (a * 10) % n;
                t++;
            } while (a != 1);

            return t;
        }
    }
}
