using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem024Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            string expected = "2783915460";

            string actual = new Problem024().Solve(1000000);

            Assert.Equal(expected, actual);
        }
    }
}
