using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem012Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            int expected = 28;

            int actual = new Problem012().Solve(5);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 76576500;

            int actual = new Problem012().Solve(500);

            Assert.Equal(expected, actual);
        }
    }
}
