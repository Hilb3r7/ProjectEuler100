using ProjectEuler100.Problems;
using Xunit;

namespace ProjectEuler100.Tests
{
    public class Problem001Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            // Arrange
            int expected = 23;

            // Act
            int actual = new Problem001().Solve(10);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            int expected = 233168;

            int actual = new Problem001().Solve(1000);

            Assert.Equal(expected, actual);
        }
    }
}
