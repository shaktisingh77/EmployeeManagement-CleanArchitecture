using MediatR;

namespace EmployeeManagement.Application.Features.Employees.Commands.DeleteEmployee;

public class DeleteEmployeeCommand : IRequest<bool>
{
    public Guid EmployeeId { get; set; }
}