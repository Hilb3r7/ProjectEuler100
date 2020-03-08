using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem028Tests
    {
        [Fact]
        public void Solve_ShouldSolveExamnple()
        {
            int expected = 101;

            int actual = new Problem028().Solve(5);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 669171001;

            int actual = new Problem028().Solve(1001);

            Assert.Equal(expected, actual);
        }
    }
}
