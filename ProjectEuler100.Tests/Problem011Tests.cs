using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem011Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 70600674;

            int actual = new Problem011().Solve(4);

            Assert.Equal(expected, actual);
        }
    }
}
