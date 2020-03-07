using ProjectEuler100.Problems;
using Xunit;

namespace ProjectEuler100.Tests
{
    public class Problem007Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            // Arrange
            int expected = 13;

            // Act
            int actual = new Problem007().Solve(6);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 104743;

            int actual = new Problem007().Solve(10001);

            Assert.Equal(expected, actual);
        }
    }
}
