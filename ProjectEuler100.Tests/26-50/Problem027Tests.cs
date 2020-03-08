using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem027Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = -59231;

            int actual = new Problem027().Solve(1000);

            Assert.Equal(expected, actual);
        }
    }
}
