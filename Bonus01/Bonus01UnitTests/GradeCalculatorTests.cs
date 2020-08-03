using Bonus01;
using Xunit;

namespace Bonus01UnitTests
{
    public class GradeCalculatorTests
    {
        [Theory]
        [InlineData(-1, null)]
        [InlineData(0, "F")]
        [InlineData(59, "F")]
        [InlineData(60, "F")]
        [InlineData(61, "D")]
        [InlineData(66, "D")]
        [InlineData(67, "C")]
        [InlineData(79, "C")]
        [InlineData(80, "B")]
        [InlineData(87, "B")]
        [InlineData(88, "A")]
        [InlineData(100, "A")]
        [InlineData(101, null)]
        public void LotsOfGradeCalculatorTests(int value, string expected)
        {
            // Arrange
            var sut = new GradeCalculator();

            // Act
            var result = sut.GetGrade(value);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
