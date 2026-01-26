namespace Lesson11.Tests
{
	// TddOopReviewDemoTests.cs
	// xUnit tests that drive the StringCalculator implementation.
	// Demonstrates the TDD cycle: write a failing test (RED), implement minimal code (GREEN), then clean up (REFACTOR).

	using System;
	using Xunit;

	public class StringCalculatorTests
	{
		private readonly StringCalculator _calc = new StringCalculator();

		// 1) Empty string -> 0
		[Fact]
		public void Add_EmptyString_ReturnsZero()
		{
			var result = _calc.Add("");
			Assert.Equal(0, result);
		}

		// 2) Single number -> that number
		[Theory]
		[InlineData("5", 5)]
		[InlineData("42", 42)]
		public void Add_SingleNumber_ReturnsValue(string input, int expected)
		{
			var result = _calc.Add(input);
			Assert.Equal(expected, result);
		}

		// 3) Two numbers comma-delimited -> sum
		[Theory]
		[InlineData("1,2", 3)]
		[InlineData("10,20", 30)]
		public void Add_TwoNumbersCommaDelimited_ReturnsSum(string input, int expected)
		{
			var result = _calc.Add(input);
			Assert.Equal(expected, result);
		}

		// 4) Newlines are valid delimiters
		[Theory]
		[InlineData("1\n2,3", 6)]
		[InlineData("7\n8\n9", 24)]
		public void Add_NewlinesAsDelimiters_ReturnsSum(string input, int expected)
		{
			var result = _calc.Add(input);
			Assert.Equal(expected, result);
		}

		// 5) Negatives throw with list of negatives in message
		[Fact]
		public void Add_Negatives_ThrowsWithAllNegativesListed()
		{
			var ex = Assert.Throws<ArgumentException>(() => _calc.Add("2,-4,3,-5"));
			Assert.Contains("Negatives not allowed", ex.Message);
			Assert.Contains("-4", ex.Message);
			Assert.Contains("-5", ex.Message);
		}

		// 6) Ignore numbers > 1000
		[Theory]
		[InlineData("2,1001", 2)]
		[InlineData("1000,1", 1001)]
		public void Add_IgnoresNumbersGreaterThan1000(string input, int expected)
		{
			var result = _calc.Add(input);
			Assert.Equal(expected, result);
		}

		// Bonus: invalid token surfaces a format error
		[Fact]
		public void Add_InvalidToken_ThrowsFormatException()
		{
			Assert.Throws<FormatException>(() => _calc.Add("1,abc,3"));
		}
	}

}
