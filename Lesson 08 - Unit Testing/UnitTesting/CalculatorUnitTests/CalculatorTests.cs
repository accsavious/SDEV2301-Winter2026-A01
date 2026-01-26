using UnitTesting;

namespace CalculatorUnitTests
{
    public class CalculatorTests
    {
        // Naming pattern for tests MUST BE:
        // MethodName_State_ExpectedResult()

        // [Theory] is used when we want to test the same logic with multiple inputs.
        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(10, 10, 20)]
        public void Add_TwoNumbers_ReturnsCorrectSum(int a, int b, int expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int sum = calculator.Add(a, b);

            // Assert
            Assert.Equal(expectedResult, sum);
        }
        // Fact is used when we are testing one specific scenario and there is only one meaningful input
        [Fact]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Subtract(10, 4);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int result = calculator.Multiply(3, 4);

            // Assert
            Assert.Equal(12, result);
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double result = calculator.Divide(10, 2);

            // When testing doubles, make sure to round the values first, you can do this using the precision option.
            // Assert
            Assert.Equal(5.0, result, precision: 1);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act and Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
        }
    }
}
