# .NET Benchmarks

All benchmarks used **.NET 7** and **BenchmarkDotNet** library.

## Introduction

The purpose of these benchmarks is to help developers identify the most efficient way based on their specific use cases.

Take the results with a grain of salt and do not micro-optimize code at the expense of readability.

Premature optimization is just something you want to avoid.

## String Concatenation Benchmarks
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

## String Parsing Benchmarks
- **int.Parse()**
- **int.TryParse()**
- **ConvertToInt32()**

|         Method | StringLength |      Mean |     Error |    StdDev |    Median |      P95 | Allocated |
|--------------- |------------- |----------:|----------:|----------:|----------:|---------:|----------:|
|       IntParse |            1 | 10.328 ns | 0.2415 ns | 0.2141 ns | 10.303 ns | 10.64 ns |         - |
|    IntTryParse |            1 |  9.915 ns | 0.2356 ns | 0.2420 ns |  9.868 ns | 10.38 ns |         - |
| ConvertToInt32 |            1 | 10.147 ns | 0.1945 ns | 0.1725 ns | 10.097 ns | 10.43 ns |         - |
|       IntParse |            2 | 10.906 ns | 0.2510 ns | 0.2348 ns | 10.757 ns | 11.30 ns |         - |
|    IntTryParse |            2 | 11.543 ns | 0.2685 ns | 0.6638 ns | 11.431 ns | 12.61 ns |         - |
| ConvertToInt32 |            2 | 10.905 ns | 0.0966 ns | 0.0807 ns | 10.897 ns | 11.03 ns |         - |
|       IntParse |            3 | 12.380 ns | 0.3234 ns | 0.9227 ns | 11.991 ns | 14.27 ns |         - |
|    IntTryParse |            3 | 12.553 ns | 0.3168 ns | 0.8726 ns | 12.154 ns | 15.18 ns |         - |
| ConvertToInt32 |            3 | 11.368 ns | 0.0363 ns | 0.0284 ns | 11.367 ns | 11.40 ns |         - |
|       IntParse |            4 | 12.929 ns | 0.0948 ns | 0.0840 ns | 12.901 ns | 13.06 ns |         - |
|    IntTryParse |            4 | 12.079 ns | 0.0316 ns | 0.0247 ns | 12.075 ns | 12.12 ns |         - |
| ConvertToInt32 |            4 | 12.330 ns | 0.0282 ns | 0.0250 ns | 12.320 ns | 12.36 ns |         - |
|       IntParse |            5 | 13.493 ns | 0.0377 ns | 0.0334 ns | 13.488 ns | 13.54 ns |         - |
|    IntTryParse |            5 | 13.207 ns | 0.0437 ns | 0.0365 ns | 13.207 ns | 13.25 ns |         - |
| ConvertToInt32 |            5 | 13.812 ns | 0.0397 ns | 0.0352 ns | 13.805 ns | 13.86 ns |         - |
|       IntParse |            6 | 14.651 ns | 0.0508 ns | 0.0424 ns | 14.640 ns | 14.72 ns |         - |
|    IntTryParse |            6 | 14.362 ns | 0.0348 ns | 0.0308 ns | 14.359 ns | 14.41 ns |         - |
| ConvertToInt32 |            6 | 14.669 ns | 0.0408 ns | 0.0341 ns | 14.666 ns | 14.72 ns |         - |
|       IntParse |            7 | 16.585 ns | 0.2845 ns | 0.2922 ns | 16.558 ns | 17.05 ns |         - |
|    IntTryParse |            7 | 16.071 ns | 0.1054 ns | 0.0986 ns | 16.064 ns | 16.22 ns |         - |
| ConvertToInt32 |            7 | 17.130 ns | 0.3721 ns | 0.6114 ns | 17.098 ns | 18.22 ns |         - |
|       IntParse |            8 | 20.203 ns | 1.0338 ns | 3.0320 ns | 18.732 ns | 26.33 ns |         - |
|    IntTryParse |            8 | 17.950 ns | 0.3913 ns | 0.4948 ns | 17.871 ns | 18.91 ns |         - |
| ConvertToInt32 |            8 | 17.723 ns | 0.2057 ns | 0.1823 ns | 17.682 ns | 18.01 ns |         - |
|       IntParse |            9 | 19.367 ns | 0.4147 ns | 0.5392 ns | 19.129 ns | 20.36 ns |         - |
|    IntTryParse |            9 | 19.216 ns | 0.4116 ns | 0.7100 ns | 18.971 ns | 20.70 ns |         - |
| ConvertToInt32 |            9 | 20.692 nss | 0.4461 ns | 0.8378 ns | 20.305 ns | 22.19 ns |         - |

## Numbers Sum Benchmarks
- **sum using for loop**
- **sum using foreach loop**
- **sum using LINQ .Sum() method**
- **sum using mathematics formula for sum of arithmetic progression**

|                   Method | NumbersAmount |            Mean |         Error |        StdDev | Allocated |
|------------------------- |-------------- |----------------:|--------------:|--------------:|----------:|
|                   SumFor |            10 |       6.7518 ns |     0.1234 ns |     0.1154 ns |         - |
|               SumForeach |            10 |       8.2227 ns |     0.0135 ns |     0.0120 ns |         - |
|                  SumLinq |            10 |       8.1213 ns |     0.0145 ns |     0.0121 ns |         - |
| SumArithmeticProgression |            10 |       0.9507 ns |     0.0067 ns |     0.0059 ns |         - |
|                   SumFor |           100 |      65.3342 ns |     0.0634 ns |     0.0562 ns |         - |
|               SumForeach |           100 |      74.9599 ns |     0.1939 ns |     0.1619 ns |         - |
|                  SumLinq |           100 |      53.3228 ns |     0.0676 ns |     0.0565 ns |         - |
| SumArithmeticProgression |           100 |       0.9564 ns |     0.0049 ns |     0.0039 ns |         - |
|                   SumFor |          1000 |     585.1603 ns |     0.7109 ns |     0.6650 ns |         - |
|               SumForeach |          1000 |     662.1417 ns |     0.5687 ns |     0.4749 ns |         - |
|                  SumLinq |          1000 |     421.2751 ns |     0.6530 ns |     0.5453 ns |         - |
| SumArithmeticProgression |          1000 |       0.9482 ns |     0.0085 ns |     0.0071 ns |         - |
|                   SumFor |         10000 |   5,791.5375 ns |     7.5752 ns |     6.7152 ns |         - |
|               SumForeach |         10000 |   6,544.7085 ns |    14.6121 ns |    13.6682 ns |         - |
|                  SumLinq |         10000 |   4,100.5732 ns |     5.7219 ns |     5.3523 ns |         - |
| SumArithmeticProgression |         10000 |       0.8839 ns |     0.0038 ns |     0.0030 ns |         - |