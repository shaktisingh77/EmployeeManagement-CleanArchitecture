using EmployeeManagement.Application.Interfaces.Authentication;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EmployeeManagement.Persistence.Authentication
{
    public class JwtTokenService : IJwtTokenService
    {
        private readonly JwtSettings _jwtSettings;

        public JwtTokenService(IOptions<JwtSettings> jwtSettings)
        {
            _jwtSettings = jwtSettings.Value;
        }

        public string GenerateToken(Guid userId, string name, string email, List<string> roles)
        {
            //generate claims
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, userId.ToString()),

                    new Claim(ClaimTypes.Name, name),

                    new Claim(ClaimTypes.Email,email)
            };

            foreach (var item in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role,item));
            }

            //create secret key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));

            //signing creadentials
            var credentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

            //create token
            var token = new JwtSecurityToken(issuer: _jwtSettings.Issuer,audience: _jwtSettings.Audience,
                                             claims: claims, expires: DateTime.UtcNow.AddMinutes(
                                                                        _jwtSettings.ExpiryMinutes),
                                             signingCredentials: credentials);

            //convert to string
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
