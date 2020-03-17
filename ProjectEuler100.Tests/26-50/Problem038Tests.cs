using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem038Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 932718654;

            int actual = new Problem038().Solve();

            Assert.Equal(expected, actual);
        }
    }
}
