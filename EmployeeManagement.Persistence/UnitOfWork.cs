using EmployeeManagement.Application.Interfaces;

namespace EmployeeManagement.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeManagementContext _employeeManagementContext;

        public UnitOfWork(EmployeeManagementContext employeeManagementContext)
        {
            _employeeManagementContext = employeeManagementContext;
        }
        public async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            await _employeeManagementContext.SaveChangesAsync(cancellationToken);
        }
    }
}
