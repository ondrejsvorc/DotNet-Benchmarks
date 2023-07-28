using BenchmarkDotNet.Attributes;
using Benchmarks.Common;

namespace Benchmarks.StringConcatenation;

[MemoryDiagnoser]
public class StringConcatenationBenchmarks
{
    /// <summary>
    /// Collection of strings to concatenate.
    /// </summary>
    private List<string> _strings = null!;

    [Params(Amount.Ten, Amount.Hundred, Amount.Thousand)]
    public int StringAmount { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _strings = new List<string>();

        for (int i = 0; i < StringAmount; i++)
        {
            _strings.Add($"Item {i}");
        }
    }

    [Benchmark]
    public string PlusOperator()
    {
        return StringConcatenation.PlusOperator(_strings);
    }

    [Benchmark]
    public string StringJoin()
    {
        return StringConcatenation.StringJoin(_strings);
    }

    [Benchmark]
    public string StringConcat()
    {
        return StringConcatenation.StringConcat(_strings);
    }

    [Benchmark]
    public string StringBuilder()
    {
        return StringConcatenation.StringBuilder(_strings);
    }

    [Benchmark]
    public string StringBuilderWithCapacity()
    {
        return StringConcatenation.StringBuilderWithCapacity(_strings);
    }
}