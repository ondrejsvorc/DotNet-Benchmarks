namespace Benchmarks.Common;

/// <summary>
/// Static class with constants representing different amounts.
/// The amounts are mostly used as arguments of [Params()] attribute.
/// </summary>
public static class Amount
{
    /// <summary>
    /// Represents the value 10.
    /// </summary>
    public const int Ten = 10;

    /// <summary>
    /// Represents the value 100.
    /// </summary>
    public const int Hundred = Ten * Ten;

    /// <summary>
    /// Represents the value 1 000.
    /// </summary>
    public const int Thousand = Ten * Hundred;

    /// <summary>
    /// Represents the value 10 000.
    /// </summary>
    public const int TenThousand = Ten * Thousand;

    /// <summary>
    /// Represents the value 100 000.
    /// </summary>
    public const int HundredThousand = Ten * TenThousand;

    /// <summary>
    /// Represents the value 1 000 000.
    /// </summary>
    public const int Milion = Ten * HundredThousand;
}