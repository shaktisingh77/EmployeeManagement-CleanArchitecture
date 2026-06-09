using EmployeeManagent.Domain.Entities;

namespace EmployeeManagement.Persistence.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeManagementContext context) : base(context)
        {

        }
    }
}
