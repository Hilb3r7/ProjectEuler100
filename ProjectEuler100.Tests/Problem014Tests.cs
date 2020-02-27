using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem014Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 837799;

            int actual = new Problem014().Solve(1000000);

            Assert.Equal(expected, actual);
        }
    }
}
