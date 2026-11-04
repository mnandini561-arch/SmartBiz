namespace SmartBiz.API.Contracts.Departments;

public sealed record DepartmentResponse(
    int Id,
    string DepartmentName,
    string? Description
);