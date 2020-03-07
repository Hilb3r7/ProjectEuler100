using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem025Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            int expected = 12;

            int actual = new Problem025().Solve(3);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 4782;

            int actual = new Problem025().Solve(1000);

            Assert.Equal(expected, actual);
        }
    }
}
