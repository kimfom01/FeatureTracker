using ProjectManager.Context;

namespace ProjectManager.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly FeatureDbContext _dbContext;
    public IClientRepository Clients { get; }

    public IProjectRepository Projects { get; }

    public IFeatureRepository Features { get; }

    public UnitOfWork(FeatureDbContext dbContext)
    {
        _dbContext = dbContext;
        Clients = new ClientRepository(dbContext);
        Projects = new ProjectRepository(dbContext);
        Features = new FeatureRepository(dbContext);
    }

    public async Task<int> SaveChanges()
    {
        return await _dbContext.SaveChangesAsync();
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
}