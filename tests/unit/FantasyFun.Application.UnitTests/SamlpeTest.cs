using Xunit;

namespace FantasyFun.Application.UnitTests
{
    public class SamlpeTest
    {
        [Fact] // atrybut 
        public void ShouldSumTwoValues()
        {
            //AAA 
            //Arrange
            var x = 1;
            var y = 2;
            var result = 3;
            var Calculator = new Calculator();

            // Act
            var sum = Calculator.SUM(x, y);

            //Assert
            Assert.Equal(result, sum);
        }

        [Theory] // atrybut 
        [InlineData(1,2,3)]
        [InlineData(6, 6, 12)]
        [InlineData(-4, 2, -2)]
        [InlineData(17, 13, 30)]
        [InlineData(20, 2, 22)]
        public void ShouldSumTwoValuesAsTheory( int x, int y, int result)
        {
            //AAA 
            //Arrange
            var Calculator = new Calculator();

            // Act
            var sum = Calculator.SUM(x, y);

            //Assert
            Assert.Equal(result, sum);
        }
    }
}