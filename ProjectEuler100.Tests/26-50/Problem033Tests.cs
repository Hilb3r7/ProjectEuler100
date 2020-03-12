using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem033Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 100;

            int actual = new Problem033().Solve();

            Assert.Equal(expected, actual);
        }
    }
}
