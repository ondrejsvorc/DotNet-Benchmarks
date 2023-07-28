using BenchmarkDotNet.Attributes;

namespace Benchmarks.StringParsing;

[MemoryDiagnoser]
public class StringParsingBenchmarks
{
    /// <summary>
    /// String to parse.
    /// </summary>
    private string _string = string.Empty;

    [Params(1, 2, 3, 4, 5, 6, 7, 8, 9)]
    public int StringLength { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _string = new string('9', StringLength);
    }

    [Benchmark]
    public int IntParse()
    {
        return StringParsing.IntParse(_string);
    }

    [Benchmark]
    public int IntTryParse()
    {
        return StringParsing.IntTryParse(_string);
    }

    [Benchmark]
    public int ConvertToInt32()
    {
        return StringParsing.ConvertToInt32(_string);
    }
}