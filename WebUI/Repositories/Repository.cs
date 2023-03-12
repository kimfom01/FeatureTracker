using Microsoft.EntityFrameworkCore;
using WebUI.Context;

namespace WebUI.Repositories;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly FeatureDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;

    public Repository(FeatureDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = dbContext.Set<TEntity>();
    }

    public virtual async Task AddAsync(TEntity entity)
    {
        await _dbContext.AddAsync(entity);
    }

    public virtual IEnumerable<TEntity> GetAll()
    {
        return _dbSet.AsNoTracking<TEntity>();
    }

    public async Task<TEntity> FindAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);

        return entity;
    }

    public virtual Task UpdateAsync(TEntity entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;

        return Task.CompletedTask;
    }

    public virtual async Task<int> SaveChangesAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }
}

