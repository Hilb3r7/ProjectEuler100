using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests._26_50
{
    public class Problem041Tests
    {
        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 7652413;

            int actual = new Problem041().Solve();

            Assert.Equal(expected, actual);
        }

    }
}
