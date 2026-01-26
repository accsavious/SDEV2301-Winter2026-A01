using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.Tests
{
	// TddOopReviewDemo.cs
	// StringCalculator: a tiny class used to demonstrate TDD (red–green–refactor).
	// Requirements tackled incrementally via tests:
	// 1) Empty string returns 0
	// 2) Single number returns its value
	// 3) Two numbers, comma-delimited, return their sum
	// 4) Support newlines as delimiters ("1\n2,3" => 6)
	// 5) Negative numbers throw with the list of negatives in the message
	// 6) Ignore numbers > 1000 (e.g., "2,1001" => 2)

	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class StringCalculator
	{
		public int Add(string numbers)
		{
			if (string.IsNullOrWhiteSpace(numbers)) return 0;

			// Split on comma or newline
			var tokens = numbers.Split(new[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);

			// Parse; collect negatives (for rule #5)
			var values = new List<int>();
			var negatives = new List<int>();

			foreach (var t in tokens)
			{
				if (!int.TryParse(t.Trim(), out var n))
					throw new FormatException($"Invalid number: '{t}'");

				if (n < 0) negatives.Add(n);
				if (n <= 1000) values.Add(n); // rule #6
			}

			if (negatives.Count > 0)
				throw new ArgumentException($"Negatives not allowed: {string.Join(", ", negatives)}");

			return values.Sum();
		}
	}

}
