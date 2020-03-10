using System.Collections.Generic;

namespace ProjectEuler100.Problems
{
    // How many different ways can £2 be made using any number of coins?
    // Solution time = 00:00:00.0009553 (iterative) time = 00:00:00.0071531 (recursive) 

    public class Problem031
    {
        public int Solve(int amount)
        {
            return GetNumWaysIterative(amount, new int[] { 1, 2, 5, 10, 20, 50, 100, 200 });
        }

        private int GetNumWaysIterative(int amount, int[] coins)
        {
            int[,] table = new int[coins.Length + 1, amount + 1];
            table[0, 0] = 1;

            for (int row = 1; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    if (col - coins[row - 1] < 0) table[row, col] = table[row - 1, col];
                    else table[row, col] = table[row - 1, col] + table[row, col - coins[row - 1]];
                }
            }

            return table[table.GetLength(0) - 1, table.GetLength(1) - 1];
        }

        // Added recursive with memoization for the giggles
        private int GetNumWaysRecursive(int amount, int[] coins, int index,  Dictionary<string, int> memo)
        {
            if (amount == 0) return 1;
            if (memo.ContainsKey($"{amount}:{index}")) return memo[$"{amount}:{index}"];

            int total = 0;
            for (int i = index; i < coins.Length; i++)
            {
                int coin = coins[i];
                if (coin <= amount) total += GetNumWaysRecursive(amount - coin, coins, i, memo);
            }

            memo.Add($"{amount}:{index}", total);
            return total;
        }
    }
}
