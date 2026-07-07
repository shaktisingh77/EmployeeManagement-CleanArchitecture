using EmployeeManagement.Application.Interfaces.Authentication;
using EmployeeManagement.Application.Interfaces.Repositories;
using EmployeeManagement.Application.Interfaces.Security;
using EmployeeManagement.Application.Models;

namespace EmployeeManagement.Persistence.Authentication
{
    public class UserAuthenticationService: IUserAuthenticationService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;

        public UserAuthenticationService(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }        

        public async Task<AuthenticatedUser?> ValidateUserAsync(string email,string password)
        {
            var user = await _userRepository.GetByUserNameAsync(email);

            if (user == null)
                return null;
                        
            if (!_passwordHasher.VerifyPassword(password,user.PasswordHash))
            {
                return null;
            }

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
