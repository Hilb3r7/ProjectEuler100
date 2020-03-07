using ProjectEuler100.Problems;
using Xunit;

namespace ProjectEuler100.Tests
{
    public class Problem003Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            // Arrange
            int expected = 29;

            // Act
            long actual = new Problem003().Solve(13195);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 6857;

            long actual = new Problem003().Solve(600851475143);

            Assert.Equal(expected, actual);
        }
    }
}

