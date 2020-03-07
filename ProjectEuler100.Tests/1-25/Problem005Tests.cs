using ProjectEuler100.Problems;
using Xunit;

namespace ProjectEuler100.Tests
{
    public class Problem005Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            // Arrange
            int expected = 2520;

            // Act
            long actual = new Problem005().Solve(10);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 232792560;

            long actual = new Problem005().Solve(20);

            Assert.Equal(expected, actual);
        }
    }
}
