using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem030Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            int expected = 19316;

            int actual = new Problem030().Solve(4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 443839;

            int actual = new Problem030().Solve(5);

            Assert.Equal(expected, actual);
        }
    }
}
