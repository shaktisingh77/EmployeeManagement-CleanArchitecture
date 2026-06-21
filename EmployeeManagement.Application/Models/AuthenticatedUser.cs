namespace EmployeeManagement.Application.Models
{
    public class AuthenticatedUser
    {
        public Guid UserId { get; set; } 

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public List<string> Roles { get; set; } = new();
    }
}
