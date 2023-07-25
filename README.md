# .NET Benchmarks

All benchmarks were done using **.NET 7** with **BenchmarkDotNet** library.

## String Concatenation Benchmarks

The purpose of these benchmarks is to help developers identify the most efficient way to concatenate strings based on their specific use cases.
- **'+' operator**
- **string.Join()**
- **string.Concat()**
- **StringBuilder**
- **StringBuilder with predefined capacity**

|                    Method | StringAmount |         Mean |       Error |      StdDev |      Gen0 | Allocated |
|-------------------------- |------------- |-------------:|------------:|------------:|----------:|----------:|
|              PlusOperator |           10 |     177.3 ns |     3.62 ns |     8.33 ns |    0.5610 |     880 B |
|                StringJoin |           10 |     126.8 ns |     2.54 ns |     2.93 ns |    0.0918 |     144 B |
|              StringConcat |           10 |     206.0 ns |     4.07 ns |     5.15 ns |    0.1173 |     184 B |
|             StringBuilder |           10 |     157.0 ns |     3.07 ns |     2.72 ns |    0.3111 |     488 B |
| StringBuilderWithCapacity |           10 |     105.4 ns |     2.08 ns |     2.56 ns |    0.2142 |     336 B |
|              PlusOperator |          100 |   7,562.5 ns |   147.21 ns |   224.80 ns |   45.4254 |   71264 B |
|                StringJoin |          100 |   1,170.2 ns |    22.70 ns |    21.24 ns |    0.8965 |    1408 B |
|              StringConcat |          100 |   1,630.7 ns |     9.94 ns |     8.30 ns |    0.9212 |    1448 B |
|             StringBuilder |          100 |     961.1 ns |    10.32 ns |     9.15 ns |    2.5234 |    3960 B |
| StringBuilderWithCapacity |          100 |     791.3 ns |     6.13 ns |     5.12 ns |    1.8244 |    2864 B |
|              PlusOperator |         1000 | 643,126.4 ns | 5,263.82 ns | 4,395.53 ns | 4973.6328 | 7825665 B |
|                StringJoin |         1000 |  10,879.8 ns |   143.82 ns |   127.49 ns |    9.9945 |   15808 B |
|              StringConcat |         1000 |  14,563.5 ns |    61.05 ns |    54.11 ns |   10.0861 |   15848 B |
|             StringBuilder |         1000 |   8,045.9 ns |    86.13 ns |    76.35 ns |   20.8282 |   32912 B |
| StringBuilderWithCapacity |         1000 |   8,132.0 ns |    99.78 ns |    93.34 ns |   19.9890 |   31664 B |

