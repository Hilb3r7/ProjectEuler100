using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem035Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            int expected = 13;

            int actual = new Problem035().Solve(100);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 55;

            int actual = new Problem035().Solve(1000000);

            Assert.Equal(expected, actual);
        }
    }
}
