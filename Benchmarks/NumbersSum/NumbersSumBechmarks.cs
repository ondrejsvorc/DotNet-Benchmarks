using BenchmarkDotNet.Attributes;
using Benchmarks.Common;

namespace Benchmarks.NumbersSum;

[MemoryDiagnoser]
public class NumbersSumBechmarks
{
    /// <summary>
    /// Collection of numbers to add up.
    /// The difference between neighbour numbers is always one.
    /// </summary>
    private List<int> _numbers = null!;

    [Params
     (
        Amount.Ten,
        Amount.Hundred,
        Amount.Thousand,
        Amount.TenThousand
     )
    ]
    public int NumbersAmount { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        _numbers = new List<int>();

        for (int i = 0; i < NumbersAmount; i++)
        {
            _numbers.Add(i);
        }
    }

    [Benchmark]
    public int SumFor()
    {
        return NumbersSum.SumFor(_numbers);
    }

    [Benchmark]
    public int SumForeach()
    {
        return NumbersSum.SumForeach(_numbers);
    }

    [Benchmark]
    public int SumLinq()
    {
        return NumbersSum.SumLinq(_numbers);
    }

    [Benchmark]
    public int SumArithmeticProgression()
    {
        return NumbersSum.SumArithmeticProgression(_numbers);
    }
}
