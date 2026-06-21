namespace EmployeeManagement.Application.Interfaces.Authentication
{
    public interface IJwtTokenService
    {
        string GenerateToken(Guid userId, string name, string email, List<string> roles);

    }
}
