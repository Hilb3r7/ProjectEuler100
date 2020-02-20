using ProjectEuler100.Problems;
using Xunit;

namespace ProjectEuler100.Tests
{
    public class Problem006Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            // Arrange
            int expected = 2640;

            // Act
            int actual = new Problem006().Solve(10);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 25164150;

            int actual = new Problem006().Solve(100);

            Assert.Equal(expected, actual);
        }
    }
}