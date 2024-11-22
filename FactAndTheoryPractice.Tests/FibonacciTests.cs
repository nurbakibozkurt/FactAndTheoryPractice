namespace FactAndTheoryPractice.Tests
{
    public class FibonacciTests
    {
        [Fact]
        public void Fibonacci_Returns_CorrectResult()
        {
            //Arrange
            int number = 8;
            FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();

            //Act
            int result = fibonacciCalculator.Calculate(number);

            //Assert
            Assert.Equal(21, result);
        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(1,1)]
        [InlineData(13, 233)]
        [InlineData(20, 6765)]
        public void Fibonacci_ValuesGreaterThanZero_Returns_CorrectResult(int number, int expected)
        {
            //Arrange
            FibonacciCalculator fibonacciCalculator = new FibonacciCalculator();

            //Act
            int result = fibonacciCalculator.Calculate(number);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}