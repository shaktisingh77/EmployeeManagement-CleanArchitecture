using EmployeeManagement.Application.Interfaces.Authentication;
using EmployeeManagement.Application.Models;

namespace EmployeeManagement.Persistence.Authentication
{
    public class UserAuthenticationService : IUserAuthenticationService
    {
        public async Task<AuthenticatedUser?> AuthenticateAsync(string email,string password)
        {
            if (email == "admin@test.com" && password == "123456")
            {
                return new AuthenticatedUser
                {
                    UserId = Guid.NewGuid().ToString(),
                    Name = "Shakti Singh",
                    Email = email,
                    Role = "Admin"
                };
            }

            return null;
        }
    }
}
