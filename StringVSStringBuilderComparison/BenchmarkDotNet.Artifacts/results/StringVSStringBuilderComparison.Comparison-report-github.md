``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.1 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742190 Hz, Resolution=364.6720 ns, Timer=TSC
.NET Core SDK=2.2.108
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                   Method |          Mean |        Error |       StdDev |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |--------------:|-------------:|-------------:|---------:|------:|------:|----------:|
|        StringPerformance | 102,961.44 ns | 2,339.446 ns | 6,598.449 ns | 490.8447 |     - |     - | 1029968 B |
| StringBuilderPerformance |      55.21 ns |     1.190 ns |     1.989 ns |   0.0495 |     - |     - |     104 B |
