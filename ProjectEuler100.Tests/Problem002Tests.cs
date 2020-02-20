using ProjectEuler100.Problems;
using Xunit;

namespace ProjectEuler100.Tests
{
    public class Problem002Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            // Arrange
            int expected = 44;

            // Act
            int actual = new Problem002().Solve(100);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 4613732;

            int actual = new Problem002().Solve(4000000);

            Assert.Equal(expected, actual);
        }
    }
}
