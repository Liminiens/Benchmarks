``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.248)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=14318180 Hz, Resolution=69.8413 ns, Timer=HPET
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|               Method |       Mean |     Error |    StdDev |
|--------------------- |-----------:|----------:|----------:|
| AggregationImmutable | 6,240.2 ns | 74.569 ns | 69.752 ns |
|   AggregationMutable | 1,478.5 ns | 10.971 ns |  9.725 ns |
|     ForeachImmutable | 6,527.3 ns | 86.808 ns | 72.489 ns |
|       ForeachMutable | 1,450.8 ns | 14.792 ns | 13.837 ns |
|           FsharpFold |   356.4 ns |  7.095 ns |  7.591 ns |
| ForeachMutableWithIf | 1,416.9 ns | 12.021 ns | 11.244 ns |
|           ForMutable |   216.1 ns |  3.696 ns |  3.457 ns |
