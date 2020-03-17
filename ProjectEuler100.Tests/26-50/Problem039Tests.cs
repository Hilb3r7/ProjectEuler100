using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem039Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 840;

            int actual = new Problem039().Solve(1000);

            Assert.Equal(expected, actual);
        }
    }
}
