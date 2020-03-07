using Xunit;
using ProjectEuler100.Problems;

namespace ProjectEuler100.Tests
{
    public class Problem008Tests
    {
        [Fact]
        public void Solve_ShouldSolveExample()
        {
            var expected = 5832;

            var actual = new Problem008().Solve(4);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solve_ShouldSolveProblem()
        {
            var expected = 23514624000;

            var actual = new Problem008().Solve(13);

            Assert.Equal(expected, actual);
        }
    }
}
