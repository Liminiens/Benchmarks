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
| AggregationImmutable | 6,203.8 ns | 81.498 ns | 76.233 ns |
|   AggregationMutable | 1,471.8 ns |  9.283 ns |  8.683 ns |
|     ForeachImmutable | 6,585.2 ns | 72.133 ns | 67.473 ns |
|       ForeachMutable | 1,416.3 ns | 15.371 ns | 14.378 ns |
|           FsharpFold |   542.0 ns |  6.581 ns |  6.156 ns |
| ForeachMutableWithIf | 1,449.4 ns | 20.184 ns | 18.880 ns |
