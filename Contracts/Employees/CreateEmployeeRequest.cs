namespace SmartBiz.API.Contracts.Employees;

public sealed record CreateEmployeeRequest
{
    public required string FirstName { get; init; }

    public string? MiddleName { get; init; }

    public required string LastName { get; init; }

    public required string Email { get; init; }

    public int DepartmentId { get; init; }
}