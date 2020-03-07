using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem010Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            long expected = 17;

            long actual = new Problem010().Solve(10);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            long expected = 142913828922;

            long actual = new Problem010().Solve(2000000);

            Assert.Equal(expected, actual);
        }
    }
}
