using System.ComponentModel.DataAnnotations;

namespace EmployeeManagent.Domain.Entities
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        [MaxLength(100)]
        public string EmployeeName { get; set; }
        [MaxLength(100)]
        public string EmailId { get; set; }
        [MaxLength(20)]
        public string PhoneNumber { get; set; }
        public decimal Salary { get; set; }
    }
}
