``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.248)
Intel Core i7-3770K CPU 3.50GHz (Ivy Bridge), 1 CPU, 8 logical cores and 4 physical cores
Frequency=14318180 Hz, Resolution=69.8413 ns, Timer=HPET
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|               Method |         Mean |       Error |      StdDev |
|--------------------- |-------------:|------------:|------------:|
| AggregationImmutable | 11,147.40 us | 119.4633 us | 111.7461 us |
|   AggregationMutable |    160.24 us |   1.5785 us |   1.4765 us |
|     ForeachImmutable | 11,160.46 us | 111.3745 us | 104.1798 us |
|       ForeachMutable |    157.53 us |   3.6666 us |   3.4297 us |
|           FsharpFold |     48.97 us |   0.5237 us |   0.4373 us |
| ForeachMutableWithIf |    157.17 us |   2.2582 us |   1.8857 us |
|           ForMutable |     22.39 us |   0.2051 us |   0.1818 us |
