using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem040Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 210;

            int actual = new Problem040().Solve();

            Assert.Equal(expected, actual);
        }
    }
}
