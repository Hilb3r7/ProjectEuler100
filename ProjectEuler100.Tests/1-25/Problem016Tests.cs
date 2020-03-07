using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem016Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            int expected = 26;

            int actual = new Problem016().Solve(15);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 1366;

            int actual = new Problem016().Solve(1000);

            Assert.Equal(expected, actual);
        }
    }
}
