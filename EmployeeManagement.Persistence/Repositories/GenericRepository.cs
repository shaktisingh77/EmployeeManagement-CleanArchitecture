
using EmployeeManagement.Persistence;
using Microsoft.EntityFrameworkCore;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly EmployeeManagementContext _context;

    public GenericRepository(EmployeeManagementContext context)
    {
        _context = context;
    }

    public async Task AddAsync(T entity,CancellationToken cancellationToken)
    {
        await _context.Set<T>()
            .AddAsync(entity, cancellationToken);
    }
    public void Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public async Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _context.Set<T>()
            .ToListAsync(cancellationToken);
    }

    public async Task<T?> GetByIdAsync(Guid id,CancellationToken cancellationToken)
    {
        return await _context.Set<T>()
            .FindAsync([id], cancellationToken);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
}