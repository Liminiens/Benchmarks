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
            BenchmarkRunner.Run<FindSequenceBenchmark>();
        }
    }
}
