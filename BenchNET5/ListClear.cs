using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace BenchNET
{
    public class ListClear
    {
        private List<int> lst;
        private List<int> lst2;

        public ListClear()
        {
            lst = new List<int>
            {
                100,
                200,
                300,
                400,
                500
            };
        }

        [Benchmark]
        public void LstAny()
        {
            if (lst.Any())
            {
                lst.Clear();
            }
        }

        [Benchmark]
        public void LstAnyEmpty()
        {
            if (lst2.Any())
            {
                lst2.Clear();
            }
        }

        [Benchmark]
        public void lstCount()
        {
            if (lst.Count > 0)
            {
                lst.Clear();
            }
        }

        [Benchmark]
        public void lstCountEmpty()
        {
            if (lst2.Count > 0)
            {
                lst2.Clear();
            }
        }

        [Benchmark]
        public void Lst()
        {
            lst.Clear();
        }

        [Benchmark]
        public void LstEmpty()
        {
            lst.Clear();
        }
    }
}