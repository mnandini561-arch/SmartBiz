namespace SmartBiz.API.Extensions;

public static class StringExtensions
{
    public static string ToCleanName(this string? value)
    {
        return value?.Trim() ?? string.Empty;
    }
}