using Xunit;

namespace Mentoring.Project02.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldAddTwoNumbers()
        {
            var calculator = new Calculator();

            var result = calculator.Sum(2, 0, 6);

            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_ShouldAddThreeNumbers()
        {
            var calculator = new Calculator();

            var result = calculator.Sum(2, 3, 6);

            Assert.Equal(11, result);
        }

        [Theory]
        [InlineData(0, 0, 0, 0)]
        [InlineData(1, 1, 1, 3)]
        [InlineData(0, 5, 10, 15)]
        public void Add_ShouldAddNumbers(
            int firstNumber, int secondNumber, int thirdNumber, int expectedResult)
        {
            var calculator = new Calculator();

            var actualResult = calculator.Sum(firstNumber, secondNumber, thirdNumber);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
