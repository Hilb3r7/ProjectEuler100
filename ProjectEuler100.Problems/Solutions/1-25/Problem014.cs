using System.Collections.Generic;

namespace ProjectEuler100.Problems
{
    // Which starting number, under one million, produces the longest chain?
    // Solution time = 00:00:00.4142866
    public class Problem014
    {
        public int Solve(int bound)
        {
            return LongestCollatzLength(bound, new Dictionary<long, int>());
        }

        private int LongestCollatzLength(int bound, Dictionary<long, int> memo)
        {
            var longest = 0;
            var length = 0;

            for (int i = 1; i < bound; i++)
            {
                int iLength = CollatzLength(i, memo);
                if (iLength > length)
                {
                    longest = i;
                    length = iLength;
                }
            }

            return longest;
        }

        private int CollatzLength(long num, Dictionary<long, int> memo)
        {
            if (memo.ContainsKey(num)) return memo[num];
            if (num == 1) return 1;

            int length = 0;
            if (num % 2 == 0) length += 1 + CollatzLength(num / 2, memo);
            else length += 1 + CollatzLength(3 * num + 1, memo);

            memo.Add(num, length);

            return length;
        }
    }
}
