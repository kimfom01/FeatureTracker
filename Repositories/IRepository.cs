namespace ProjectManager.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    Task AddAsync(TEntity entity);
    IEnumerable<TEntity> GetAll();
    Task<TEntity> FindAsync(int id);
    Task<int> SaveChangesAsync();
    Task UpdateAsync(TEntity entity);
}