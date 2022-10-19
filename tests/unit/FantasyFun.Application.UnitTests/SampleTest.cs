namespace FantasyFun.Application.UnitTests
{
    public class SampleTest
    {
        [Fact]
        public void ShouldSumTwoValues()
        {
            // Arrange
            var x = 1;
            var y = 2;
            var result = 3;
            var calculator = new Calculator();

            // Act
            var sum = calculator.Sum(x, y);

            // Assert
            Assert.Equal(result, sum);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, 2, 1)]
        [InlineData(100, 99, 199)]
        [InlineData(2, 2, 4)]
        public void ShouldSumTwoValuesAsTheory(int x, int y, int result)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var sum = calculator.Sum(x, y);

            // Assert
            Assert.Equal(result, sum);
        }
    }
}