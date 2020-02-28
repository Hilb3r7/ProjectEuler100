using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem015Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            int expected = 6;

            long actual = new Problem015().Solve(2, 2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            long expected = 137846528820;

            long actual = new Problem015().Solve(20, 20);

            Assert.Equal(expected, actual);
        }
    }
}
