using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler100.Problems
{
    // Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.
    // Solution time = 00:00:00.0111182
    public class Problem032
    {
        public int Solve()
        {
            return GetPandProductSum();
        } 

        // We can only have two digit * 3 digit numbers or one digit * four digit numbers 
        private int GetPandProductSum()
        {
            var products = new HashSet<int>();

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (j == i) continue;

                    for (int x = 1; x < 10; x++)
                    {
                        if (x == j || x == i) continue;
                        
                        for (int y = 1; y < 10; y++)
                        {
                            if (y == x || y == j || y == i) continue;
                            
                            for (int z = 2; z < 10; z++) // always last didigt, so can't be a 1
                            {
                                if (z == y || z == x || z == j || z == i) continue;

                                int twoDig = i * 10 + j;
                                int threeDig = x * 100 + y * 10 + z;
                                int fourDig = j * 1000 + x * 100 + y * 10 + z;
                                int product23 = twoDig * threeDig;
                                int product14 = i * fourDig;
                                if (product23 < 9877)
                                {
                                    if (IsProductPand(x, y, z, i, j, product23)) products.Add(product23);
                                }
                                if (product14 < 9877)
                                {
                                    if (IsProductPand(x, y, z, i, j, product14)) products.Add(product14);
                                }
                            }
                        }
                    }
                }
            }

            return products.Sum();
        }

        // ijxyz don't contain dupe digits, so we only have to check product doesn't contain
        // dupes, a zero, or an ijxyz
        private bool IsProductPand(int x, int y, int z, int i, int j, int product)
        {
            var digits = new HashSet<int>();
            while (product > 0)
            {
                int digit = product % 10;
                if (digit == x || digit == y || digit == z || digit == i || digit == j || digit == 0 || !digits.Add(digit))
                {
                    return false;
                }
                product /= 10;
            }

            return true;
        }
    }
}
