using AutoMapper;
using EmployeeManagement.Application.Exceptions;
using EmployeeManagement.Application.Interfaces;
using EmployeeManagent.Domain.Entities;
using MediatR;

namespace EmployeeManagement.Application.Features.Employees.Commands.UpdateEmployee;

public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommand>
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper, 
                                        IUnitOfWork unitOfWork)
    {        
        _employeeRepository = employeeRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(UpdateEmployeeCommand request,CancellationToken cancellationToken)
    {
        var employee = await _employeeRepository.GetByIdAsync(request.EmployeeId,cancellationToken);

        if (employee == null)
        {
            throw new NotFoundException(nameof(Employee),request.EmployeeId);
        }

        employee.EmployeeName = request.EmployeeName;
        employee.EmailId = request.EmailId;
        employee.PhoneNumber = request.PhoneNumber;
        employee.Salary = request.Salary;

        _employeeRepository.Update(employee);

        await _unitOfWork.SaveChangesAsync(cancellationToken);        
    }
}