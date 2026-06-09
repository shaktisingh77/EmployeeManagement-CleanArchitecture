using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Application.DTOs
{
    public class EmployeeDto
    {
        public Guid EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailId { get; set; }

        public string PhoneNumber { get; set; }
        [Range(0, 100000000)]
        public decimal Salary { get; set; }
    }
}
