using Microsoft.EntityFrameworkCore;
using ProjectManager.Context;

namespace ProjectManager.Repositories;

public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly FeatureDbContext DbContext;
    private readonly DbSet<TEntity> _dbSet;

    public Repository(FeatureDbContext dbContext)
    {
        DbContext = dbContext;
        _dbSet = dbContext.Set<TEntity>();
    }

    public virtual async Task AddAsync(TEntity entity)
    {
        await DbContext.AddAsync(entity);
    }

    public virtual IEnumerable<TEntity> GetAll()
    {
        return _dbSet.AsNoTracking<TEntity>();
    }

    public async Task<TEntity?> FindAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);

        return entity;
    }

    public virtual Task UpdateAsync(TEntity entity)
    {
        DbContext.Entry(entity).State = EntityState.Modified;

        return Task.CompletedTask;
    }
}

