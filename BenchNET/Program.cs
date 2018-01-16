using BenchmarkDotNet.Running;
using System;

namespace BenchNET
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<Iterate>();

			Console.ReadLine();
		}
	}
}