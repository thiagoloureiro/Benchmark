using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

namespace BenchNET
{
	public class Iterate
	{
		private List<string> lstStr;
		private int Counter;

		public Iterate()
		{
			lstStr = new List<string>
			{
				"String1",
				"String2",
				"String3",
				"String4",
				"String5",
				"String6",
				"String7",
				"String8",
				"String9",
				"String10"
			};
		}

		[Benchmark]
		public int List_For()
		{
			for (int i = 0; i < lstStr.Count; i++)
			{
				Counter++;
			}
			return Counter;
		}

		[Benchmark]
		public int List_Foreach()
		{
			foreach (var item in lstStr)
			{
				Counter++;
			}
			return Counter;
		}
	}
}