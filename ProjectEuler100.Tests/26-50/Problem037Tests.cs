using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem037Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 748317;

            int actual = new Problem037().Solve();

            Assert.Equal(expected, actual);
        }
    }
}
