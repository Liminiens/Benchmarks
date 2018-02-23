using System;
using BenchmarkDotNet.Running;
using Benchmarks.Benchmarks;
using FSharp;

namespace Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = FindSequenceFSharp.getResult();
            var b = new FindSequenceBenchmark().AggregationImmutable();
            BenchmarkRunner.Run<FindSequenceBenchmark>();
        }
    }
}
