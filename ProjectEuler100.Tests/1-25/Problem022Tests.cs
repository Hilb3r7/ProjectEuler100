using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem022Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 871198282;

            int actual = new Problem022().Solve();

            Assert.Equal(expected, actual);
        }
    }
}
