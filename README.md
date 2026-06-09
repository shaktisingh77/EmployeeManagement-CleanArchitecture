# Employee Management - Clean Architecture

ASP.NET Core Web API implementing Clean Architecture principles with CQRS, MediatR, Generic Repository Pattern, Unit of Work Pattern and Entity Framework Core.

## Technologies Used

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- MediatR
- AutoMapper
- FluentValidation
- CQRS
- Generic Repository Pattern
- Unit Of Work Pattern
- Dependency Injection
- Global Exception Handling Middleware
- Clean Architecture

## Solution Structure

```text
EmployeeManagement.API
EmployeeManagement.Application
EmployeeManagement.Domain
EmployeeManagement.Persistence
```

## Request Flow

```text
Controller
↓
Mediator
↓
ValidationBehavior
↓
Handler
↓
Repository
↓
UnitOfWork
↓
DbContext
↓
SQL Server
```

## Features Implemented

- Create Employee
- Get All Employees
- Get Employee By Id
- Update Employee
- Delete Employee
- CQRS using MediatR
- FluentValidation
- AutoMapper
- Generic Repository Pattern
- Unit Of Work Pattern
- Dependency Injection Extensions
- Global Exception Handling Middleware

## Future Enhancements

- Logging Behavior
- Performance Behavior
- JWT Authentication
- Authorization
- Serilog
- Application Insights
- Specification Pattern
- Modular Monolith
- Microservices

## Status

Current phase:

**Crawl → Walk → Run**

Learning and evolving one step at a time.
