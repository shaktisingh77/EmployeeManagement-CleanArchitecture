using System.ComponentModel.DataAnnotations;

namespace EmployeeManagent.Domain.Entities
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmailId { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Salary { get; set; }
    }
}
