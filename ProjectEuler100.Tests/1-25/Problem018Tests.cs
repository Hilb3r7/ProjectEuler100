using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem018Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 1074;

            int actual = new Problem018().Solve();

            Assert.Equal(expected, actual);
        }
    }
}
