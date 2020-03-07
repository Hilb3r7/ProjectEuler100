using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem013Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            string expected = "5537376230";

            string actual = new Problem013().Solve(10);

            Assert.Equal(expected, actual);
        }
    }
}
