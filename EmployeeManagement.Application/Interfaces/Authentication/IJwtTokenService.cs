namespace EmployeeManagement.Application.Interfaces.Authentication
{
    public interface IJwtTokenService
    {
        string GenerateToken(string userId, string name, string email, string role);
    }
}
