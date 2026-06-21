using EmployeeManagement.Application.Interfaces.Authentication;
using EmployeeManagement.Application.Interfaces.Repositories;
using EmployeeManagement.Application.Models;

namespace EmployeeManagement.Persistence.Authentication
{
    public class UserAuthenticationService: IUserAuthenticationService
    {
        private readonly IUserRepository _userRepository;

        public UserAuthenticationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }        

        public async Task<AuthenticatedUser?> ValidateUserAsync(string email,string password)
        {
            var user = await _userRepository.GetByUserNameAsync(email);

            if (user == null)
                return null;

            // password hashing later
            if (user.PasswordHash != password)
                return null;

            return new AuthenticatedUser
            {
                UserId = user.UserId,
                Name = user.UserName,
                Email = user.Email,
                Roles = user.Roles
                           .Select(r => r.RoleName)
                           .ToList()
            };
        }
    }
}
