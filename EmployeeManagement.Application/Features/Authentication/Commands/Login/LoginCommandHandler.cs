using EmployeeManagement.Application.Interfaces.Authentication;
using MediatR;

namespace EmployeeManagement.Application.Features.Authentication.Commands.Login
{

    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponse>
    {
        private readonly IUserAuthenticationService _authenticationService;
        private readonly IJwtTokenService _jwtTokenService;

        public LoginCommandHandler(IUserAuthenticationService authenticationService,
                                    IJwtTokenService jwtTokenService)
        {
            _authenticationService = authenticationService;
            _jwtTokenService = jwtTokenService;
        }

        public async Task<LoginResponse> Handle(LoginCommand request,CancellationToken cancellationToken)
        {
            var user = await _authenticationService.AuthenticateAsync(request.Email,request.Password);

            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid email or password.");
            }

            var token = _jwtTokenService.GenerateToken(user.UserId,user.Name,user.Email,user.Role);

            return new LoginResponse
            {
                Token = token
            };
        }
    }
}
