using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem029Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            int expected = 15;

            int actual = new Problem029().Solve(5, 5);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 9183;

            int actual = new Problem029().Solve(100, 100);

            Assert.Equal(expected, actual);
        }
    }
}
