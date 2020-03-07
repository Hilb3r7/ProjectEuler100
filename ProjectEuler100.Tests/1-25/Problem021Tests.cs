using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem021Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 31626;

            int actual = new Problem021().Solve(10000);

            Assert.Equal(expected, actual);
        }
    }
}
