using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem019Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 171;

            int actual = new Problem019().Solve();

            Assert.Equal(expected, actual);
        }
    }
}
