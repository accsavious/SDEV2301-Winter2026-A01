using Lesson_8_unit_tests;
namespace CalDemoTest
{
    public class CalculatorTests
    {
        // MethodName_State_ExpectedResult
        // f
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(4, 5, 9)]
        public void Add_TwoNumbers_ReturnsCorrectSum(int a, int b, int expectedSum)
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            int sum = calculator.Add(a, b);
            // Assert
            Assert.Equal(expectedSum, sum);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsCorrectDifference()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            int a = 4;
            int b = 3;
            int expectedResult = a - b;
            int diff = calculator.Subtract(a, b);
            // Assert
            Assert.Equal(expectedResult, diff);
        }
        [Fact]
        public void Divide_TwoNumbers_ReturnsCorrectQuotient()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            int a = 4;
            int b = 3;
            double expectedResult = Math.Round((double)a/b, 2);
            double quo = Math.Round(calculator.Divide(a, b),2);
            // Assert
            Assert.Equal(expectedResult, quo);
        }
        [Fact]
        public void Divide_DivisorZero_ThrowsDivideByZeroException()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(5, 0));
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsCorrectProduct()
        {
            // Arrange
            Calculator calculator = new Calculator();
            // Act
            int a = 4;
            int b = 3;
            int expectedResult = a * b;
            int prod = calculator.Multiply(a, b);
            // Assert
            Assert.Equal(expectedResult, prod);
        }
    }
}
