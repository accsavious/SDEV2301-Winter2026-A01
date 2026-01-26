namespace Lesson11.Tests.Guided
{
	// TddOopReviewDemoTests_Guided.cs
	// Guided xUnit tests for the String Calculator kata (Red → Green → Refactor)

	using System;
	using Xunit;

	public class StringCalculator_GuidedTests
	{
		// TIP: Create calculator instance in each test or once per class.
		// private readonly StringCalculator _calc = new StringCalculator();

		[Fact]
		public void Add_EmptyString_ReturnsZero()
		{
			// TODO Arrange
			// var calc = new StringCalculator();
			// var input = "";

			// TODO Act
			// var result = calc.Add(input);

			// TODO Assert
			// Assert.Equal(0, result);
		}

		[Theory]
		[InlineData("5", 5)]
		[InlineData("42", 42)]
		public void Add_SingleNumber_ReturnsValue(string input, int expected)
		{
			// TODO Arrange
			// var calc = new StringCalculator();

			// TODO Act
			// var result = calc.Add(input);

			// TODO Assert
			// Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData("1,2", 3)]
		[InlineData("10,20", 30)]
		public void Add_TwoNumbers_CommaDelimited_ReturnsSum(string input, int expected)
		{
			// TODO Arrange
			// var calc = new StringCalculator();

			// TODO Act
			// var result = calc.Add(input);

			// TODO Assert
			// Assert.Equal(expected, result);
		}

		[Theory]
		[InlineData("1\n2,3", 6)]
		[InlineData("7\n8\n9", 24)]
		public void Add_NewlinesAsDelimiters_ReturnsSum(string input, int expected)
		{
			// TODO Arrange
			// var calc = new StringCalculator();

			// TODO Act
			// var result = calc.Add(input);

			// TODO Assert
			// Assert.Equal(expected, result);
		}

		[Fact]
		public void Add_Negatives_ThrowsWithAllNegativesListed()
		{
			// TODO Arrange
			// var calc = new StringCalculator();
			// var input = "2,-4,3,-5";

			// TODO Assert (no Act when using Throws)
			// var ex = Assert.Throws<ArgumentException>(() => calc.Add(input));
			// Assert.Contains("Negatives not allowed", ex.Message);
			// Assert.Contains("-4", ex.Message);
			// Assert.Contains("-5", ex.Message);
		}

		[Theory]
		[InlineData("2,1001", 2)]
		[InlineData("1000,1", 1001)]
		public void Add_IgnoresNumbersGreaterThan1000(string input, int expected)
		{
			// TODO Arrange
			// var calc = new StringCalculator();

			// TODO Act
			// var result = calc.Add(input);

			// TODO Assert
			// Assert.Equal(expected, result);
		}

		[Fact]
		public void Add_InvalidToken_ThrowsFormatException()
		{
			// TODO Arrange
			// var calc = new StringCalculator();
			// var input = "1,abc,3";

			// TODO Assert
			// Assert.Throws<FormatException>(() => calc.Add(input));
		}
	}


}
