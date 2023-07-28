namespace Benchmarks.StringParsing;

/// <summary>
/// Static class with all string parsing benchmark methods.
/// </summary>
public static class StringParsing
{
    /// <summary>
    /// Parses the input text into an integer using the int.Parse method.
    /// </summary>
    /// <param name="text">The string representation of the integer.</param>
    /// <returns>The parsed integer value.</returns>
    public static int IntParse(string text)
    {
        return int.Parse(text);
    }

    /// <summary>
    /// Tries to parse the input text into an integer using the int.TryParse method.
    /// </summary>
    /// <param name="text">The string representation of the integer.</param>
    /// <returns>
    /// The parsed integer value if successful; otherwise, 0.
    /// If the parsing fails, the output parameter 'result' will be set to 0.
    /// </returns>
    public static int IntTryParse(string text)
    {
        _ = int.TryParse(text, out int result);
        return result;
    }

    /// <summary>
    /// Converts the input text into an integer using the Convert.ToInt32 method.
    /// </summary>
    /// <param name="text">The string representation of the integer.</param>
    /// <returns>The converted integer value.</returns>
    public static int ConvertToInt32(string text)
    {
        return Convert.ToInt32(text);
    }
}