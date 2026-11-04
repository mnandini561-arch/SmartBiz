namespace SmartBiz.API.Models;

public sealed record Employee(
    int Id,
    string FirstName,
    string? MiddleName,
    string LastName,
    string Email,
    decimal Salary
);