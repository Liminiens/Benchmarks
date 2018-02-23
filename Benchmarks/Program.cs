using System;
using System.Collections.Generic;
using System.Linq;
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
