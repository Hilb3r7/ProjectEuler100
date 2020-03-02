using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem017Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 21124;

            int actual = new Problem017().Solve(1000);

            Assert.Equal(expected, actual);
        }
    }
}
