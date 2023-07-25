using System.Text;

namespace Benchmarks.StringConcatenation;

/// <summary>
/// Static class with all string benchmark methods.
/// </summary>
public static class StringConcatenation
{
    /// <summary>
    /// Concatenates strings using the '+' operator.
    /// </summary>
    /// <param name="strings">A list of strings to concatenate.</param>
    /// <returns>The concatenated string.</returns>
    public static string PlusOperator(List<string> strings)
    {
        // Prepare result string.
        string result = string.Empty;

        // Loop through each string in the list and concatenate it to the result.
        for (int i = 0; i < strings.Count; i++)
        {
            result += strings[i];
        }

        // Retrieve the final concatenated string.
        return result;
    }

    /// <summary>
    /// Concatenates strings using the string.Join() method.
    /// </summary>
    /// <param name="strings">A list of strings to concatenate.</param>
    /// <returns>The concatenated string.</returns>
    public static string StringJoin(List<string> strings)
    {
        return string.Join("", strings);
    }

    /// <summary>
    /// Concatenates strings using the string.Concat() method.
    /// </summary>
    /// <param name="strings">A list of strings to concatenate.</param>
    /// <returns>The concatenated string.</returns>
    public static string StringConcat(List<string> strings)
    {
        return string.Concat(strings);
    }

    /// <summary>
    /// Concatenates strings using the StringBuilder class.
    /// </summary>
    /// <param name="strings">A list of strings to concatenate.</param>
    /// <returns>The concatenated string.</returns>
    public static string StringBuilder(List<string> strings)
    {
        // Prepare StringBuilder.
        var stringBuilder = new StringBuilder();

        // Loop through each string in the list and append it to the StringBuilder.
        for (int i = 0; i < strings.Count; i++)
        {
            stringBuilder.Append(strings[i]);
        }

        // Retrieve the final concatenated string.
        return stringBuilder.ToString();
    }

    /// <summary>
    /// Concatenates strings using the StringBuilder class with an optimal initial capacity.
    /// </summary>
    /// <param name="strings">A list of strings to concatenate.</param>
    /// <returns>The concatenated string.</returns>
    public static string StringBuilderWithCapacity(List<string> strings)
    {
        // Calculate the optimal initial capacity for the StringBuilder.
        int capacity = GetOptimalCapacity(strings);

        // Create a new StringBuilder instance with the calculated capacity.
        var stringBuilder = new StringBuilder(capacity);

        // Loop through each string in the list and append it to the StringBuilder.
        for (int i = 0; i < strings.Count; i++)
        {
            stringBuilder.Append(strings[i]);
        }

        // Retrieve the final concatenated string.
        return stringBuilder.ToString();
    }

    /// <summary>
    /// Helper method to calculate the optimal initial capacity for the StringBuilder.
    /// </summary>
    /// <param name="strings">A list of strings to concatenate.</param>
    /// <returns>The calculated capacity.</returns>
    private static int GetOptimalCapacity(List<string> strings)
    {
        // Prepare capacity.
        int capacity = 0;

        // Loop through each string in the list and add its length to the capacity.
        for (int i = 0; i < strings.Count; i++)
        {
            capacity += strings[i].Length;
        }

        // Retrieve the calculated capacity.
        return capacity;
    }
}

