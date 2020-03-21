using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem043Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            long expected = 16695334890;

            long actual = new Problem043().Solve();

            Assert.Equal(expected, actual);
        }
    }
}
