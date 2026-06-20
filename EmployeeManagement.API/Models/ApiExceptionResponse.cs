namespace EmployeeManagement.API.Models;

public class ApiExceptionResponse
{
    public int StatusCode { get; set; }

    public string Message { get; set; } = string.Empty;
}