using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler100.Problems
{
    // What is the greatest product of four adjacent numbers in the same direction 
    // (up, down, left, right, or diagonally) in the 20×20 grid?
    // Solution time = 00:00:00.0256848
    public class Problem011
    {
        // Has to be a square grid, no error checking
        public int Solve(int numAdjacent)
        {
            return GetLargestProduct(numAdjacent, ParseInput());

        }

        private List<int> ParseInput()
        {
            return Properties.Resources.Problem11
                 .Split(new char[0], StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse).ToList();
        }


        private int GetLargestProduct(int numAdjacent, List<int> grid)
        {
            return Max(GetLargestHorizontalProduct(numAdjacent, grid),
                        GetLargestVerticalProduct(numAdjacent, grid),
                        GetLargestRightDiagonalProduct(numAdjacent, grid),
                        GetLargestLeftDiagonalProduct(numAdjacent, grid));
        }

        private int GetLargestHorizontalProduct(int numAdjacent, List<int> grid)
        {
            int size = (int) Math.Sqrt(grid.Count);
            int largest = 0;

            for (int i = 0; i < grid.Count; i++)
            {
                int col = i % size;
                int product = 1;

                if (col <= size - numAdjacent)
                {
                    for (int j = 0; j < numAdjacent; j++)
                    {
                        product *= grid[i + j];
                    }

                    if (product > largest) largest = product;
                }
            }

            return largest;
        }

        private int GetLargestVerticalProduct(int numAdjacent, List<int> grid)
        {
            int size = (int) Math.Sqrt(grid.Count);
            int largest = 0;

            for (int i = 0; i < grid.Count; i++)
            {
                int row = i / size;
                int product = 1;

                if (row <= size - numAdjacent)
                {
                    for (int j = 0; j < numAdjacent; j++)
                    {
                        product *= grid[i + (j * size)];
                    }

                    if (product > largest) largest = product;
                }
            }

            return largest;
        }

        private int GetLargestRightDiagonalProduct(int numAdjacent, List<int> grid)
        {
            int size = (int) Math.Sqrt(grid.Count);
            int largest = 0;

            for (int i = 0; i < grid.Count; i++)
            {
                int row = i / size;
                int col = i % size;
                int product = 1;

                if (row <= size - numAdjacent && col <=  size - numAdjacent)
                {
                    for (int j = 0; j < numAdjacent; j++)
                    {
                        product *= grid[i + (j * size) + j];
                    }

                    if (product > largest) largest = product;
                }
            }

            return largest;
        }

        private int GetLargestLeftDiagonalProduct(int numAdjacent, List<int> grid)
        {
            int size = (int)Math.Sqrt(grid.Count);
            int largest = 0;

            for (int i = 0; i < grid.Count; i++)
            {
                int row = i / size;
                int col = i % size;
                int product = 1;

                if (row <= size - numAdjacent && col >= numAdjacent)
                {
                    for (int j = 0; j < numAdjacent; j++)
                    {
                        product *= grid[i + (j * size) - j];
                    }

                    if (product > largest) largest = product;
                }
            }

            return largest;
        }

        private int Max(int a, int b, int c, int d)
        {
            return Math.Max(a, Math.Max(b, Math.Max(c, d)));
        }
    }
}
