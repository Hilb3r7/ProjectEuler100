using ProjectEuler100.Problems;
using Xunit;

namespace ProjectEuler100.Tests
{
    public class Problem004Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            // Arrange
            int expected = 9009;

            // Act
            int actual = new Problem004().Solve(2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 906609;

            int actual = new Problem004().Solve(3);

            Assert.Equal(expected, actual);
        }
    }
}
