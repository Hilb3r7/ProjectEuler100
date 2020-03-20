using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem042Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 162;

            int actual = new Problem042().Solve();

            Assert.Equal(expected, actual);
        }
    }
}
