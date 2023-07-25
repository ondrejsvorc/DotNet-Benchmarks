using BenchmarkDotNet.Running;
using Benchmarks.StringConcatenation;

// Run string concatenation benchmarks.
BenchmarkRunner.Run<StringBenchmarks>();
