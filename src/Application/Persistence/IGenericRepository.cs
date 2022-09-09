namespace Application.Persistence;

public interface IGenericRepository<T> where T : class
{
    Task<T> GetAsync(int id);
    Task<IReadOnlyCollection<T>> GetAllAsync();
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
}