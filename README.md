# Benchmark
[![Build status](https://ci.appveyor.com/api/projects/status/44kh33bly9aa6a3y?svg=true)](https://ci.appveyor.com/project/thiagoloureiro/benchmark)

Code sample for an article posted on Medium:
https://medium.com/@thiagoloureiro/benchmark-medindo-a-performance-na-sua-aplicacac%C3%A3o-8deef4a8fae2

Using Bechmarkdotnet component.

Output

``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.475 (1809/October2018Update/Redstone5)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3362.0
  DefaultJob : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.3362.0


```
|       Method |     Mean |     Error |    StdDev |
|------------- |---------:|----------:|----------:|
|     List_For | 11.46 ns | 0.0685 ns | 0.0641 ns |
| List_Foreach | 48.92 ns | 0.1628 ns | 0.1443 ns |
