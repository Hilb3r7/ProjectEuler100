using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem031Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 73682;

            int actual = new Problem031().Solve(200);

            Assert.Equal(expected, actual);
        }
    }
}
