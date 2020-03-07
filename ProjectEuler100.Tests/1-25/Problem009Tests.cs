using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem009Tests
    {
        [Fact]
        public void Solve_ShouldSolvePoblemExample()
        {
            int expected = 60;

            int actual = new Problem009().Solve(12);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblemSolution()
        {
            int expected = 31875000;

            int actual = new Problem009().Solve(1000);

            Assert.Equal(expected, actual);
        }
    }
}
