using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem020Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 648;

            int actual = new Problem020().Solve(100);

            Assert.Equal(expected, actual);
        }
    }
}
