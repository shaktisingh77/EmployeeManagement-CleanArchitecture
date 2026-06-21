namespace EmployeeManagement.Domain.Entities;

public class User
{
    public Guid UserId { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string PasswordHash { get; set; }

    public bool IsActive { get; set; }

    public ICollection<Role> Roles { get; set; }
        = new List<Role>();
}