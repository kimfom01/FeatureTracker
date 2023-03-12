namespace ProjectManager.Repositories;

public interface IUnitOfWork : IDisposable
{
    public IClientRepository Clients { get; }
    public IProjectRepository Projects { get; }
    public IFeatureRepository Features { get; }

    public Task<int> SaveChanges();
}