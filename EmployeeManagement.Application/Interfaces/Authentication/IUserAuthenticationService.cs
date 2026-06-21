using EmployeeManagement.Application.Models;

namespace EmployeeManagement.Application.Interfaces.Authentication
{
    public interface IUserAuthenticationService
    {
        Task<AuthenticatedUser?> ValidateUserAsync(string email,string password);
    }
}
