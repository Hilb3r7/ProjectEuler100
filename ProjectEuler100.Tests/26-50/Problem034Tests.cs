using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem034Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 40730;

            int actual = new Problem034().Solve();

            Assert.Equal(expected, actual);
        }
    }
}
