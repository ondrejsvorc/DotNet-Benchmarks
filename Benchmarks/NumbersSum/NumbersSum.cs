namespace Benchmarks.NumbersSum;

/// <summary>
/// Static class with all numbers sum benchmark methods.
/// </summary>
public static class NumbersSum
{
    /// <summary>
    /// Calculates the sum of a collection of numbers using a for loop.
    /// </summary>
    /// <param name="numbers">The list of numbers to sum.</param>
    /// <returns>The sum of all the numbers in the list.</returns>
    public static int SumFor(List<int> numbers)
    {
        // Prepare sum result.
        int result = 0;

        // Perform the sum.
        for (int i = 0; i < numbers.Count; i++)
        {
            result += numbers[i];
        }

        // Retrieve the sum.
        return result;
    }

    /// <summary>
    /// Calculates the sum of a collection of numbers using a foreach loop.
    /// </summary>
    /// <param name="numbers">The list of numbers to sum.</param>
    /// <returns>The sum of all the numbers in the list.</returns>
    public static int SumForeach(List<int> numbers)
    {
        // Prepare sum result.
        int result = 0;

        // Perform the sum.
        foreach (int number in numbers)
        {
            result += number;
        }

        // Retrieve the sum.
        return result;
    }

    /// <summary>
    /// Calculates the sum of a collection of numbers using LINQ's Sum method.
    /// </summary>
    /// <param name="numbers">The list of numbers to sum.</param>
    /// <returns>The sum of all the numbers in the list.</returns>
    public static int SumLinq(List<int> numbers)
    {
        return numbers.Sum();
    }

    /// <summary>
    /// Calculates the sum of a collection of numbers using the arithmetic progression formula.
    /// </summary>
    /// <param name="numbers">The list of numbers to sum (assumes consecutive numbers with a common difference of 1).</param>
    /// <returns>The sum of all the numbers in the list.</returns>
    public static int SumArithmeticProgression(List<int> numbers)
    {
        return (numbers.Count) * (numbers[0] + numbers[^1]) / 2;
    }
}