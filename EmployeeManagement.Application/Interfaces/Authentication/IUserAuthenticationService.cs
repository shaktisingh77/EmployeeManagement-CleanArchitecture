using EmployeeManagement.Application.Models;

namespace EmployeeManagement.Application.Interfaces.Authentication
{
    public interface IUserAuthenticationService
    {
        Task<AuthenticatedUser?> AuthenticateAsync(string email,string password);
    }
}
