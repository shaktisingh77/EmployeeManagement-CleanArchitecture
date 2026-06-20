namespace EmployeeManagement.API.Models;

public class ApiValidationExceptionResponse
{
    public int StatusCode { get; set; }

    public List<string> Errors { get; set; } = new();
}