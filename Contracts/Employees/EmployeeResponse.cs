namespace SmartBiz.API.Contracts.Employees;

public sealed record EmployeeResponse
{
    public int Id { get; init; }

    public required string FullName { get; init; }

    public required string Email { get; init; }

    public required string DepartmentName { get; init; }
}