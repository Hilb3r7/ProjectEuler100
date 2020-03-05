using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem023Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 4179871;

            int actual = new Problem023().Solve();

            Assert.Equal(expected, actual);
        }
    }
}
