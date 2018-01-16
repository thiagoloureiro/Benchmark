using BenchmarkDotNet.Attributes;

namespace BenchNET
{
	public class StringTest
	{
		private const string part1 = "Part 1";
		private const string part2 = "Part 2";
		private const string part3 = "Part 3";

		[Benchmark]
		public string Convert1()
		{
			return "Testing" + part1 + "Middle" + part2 + part3 + "End";
		}

		[Benchmark]
		public string ConvertInterpolation()
		{
			return $"Testing {part1} Middle {part2}{part3} End";
		}
	}
}