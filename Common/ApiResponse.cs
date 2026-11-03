namespace SmartBiz.API.Common;

public sealed record ApiResponse<T>
{
    public bool Success { get; init; }

    public required string Message { get; init; }

    public T? Data { get; init; }
}