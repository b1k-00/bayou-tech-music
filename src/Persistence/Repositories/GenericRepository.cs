using Application.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly BayouTechDbContext _dbContext;

    public GenericRepository(BayouTechDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbContext.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IReadOnlyCollection<T>> GetAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }

    public async Task<T> GetAsync(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}
