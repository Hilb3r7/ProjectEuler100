using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem032Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 45228;

            int actual = new Problem032().Solve();

            Assert.Equal(expected, actual);
        }
    }
}
