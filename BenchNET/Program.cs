using BenchmarkDotNet.Running;
using System;

namespace BenchNET
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			BenchmarkRunner.Run<Iterate>();
			BenchmarkRunner.Run<ListClear>();
			BenchmarkRunner.Run<Md5VsSha256>();

			Console.ReadLine();
		}
	}
}