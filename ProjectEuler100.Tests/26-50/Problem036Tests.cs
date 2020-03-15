using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem036Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 872187;

            int actual = new Problem036().Solve(1000000);

            Assert.Equal(expected, actual);
        }
    }
}
