using MediatR;

namespace EmployeeManagement.Application.Features.Employees.Commands.DeleteEmployee;

public class DeleteEmployeeCommand : IRequest
{
    public Guid EmployeeId { get; set; }
}