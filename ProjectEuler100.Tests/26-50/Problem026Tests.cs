using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem026Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            int expected = 7;

            int actual = new Problem026().Solve(10);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 983;

            int actual = new Problem026().Solve(1000);

            Assert.Equal(expected, actual);
        }
    }
}
