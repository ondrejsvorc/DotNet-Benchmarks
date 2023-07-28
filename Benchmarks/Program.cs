using BenchmarkDotNet.Running;
using Benchmarks.StringConcatenation;
using Benchmarks.StringParsing;

// Run string concatenation benchmarks.
BenchmarkRunner.Run<StringConcatenationBenchmarks>();

// Run string parsing benchmarks.
BenchmarkRunner.Run<StringParsingBenchmarks>();
