using ProjectManager.Context;
using ProjectManager.Models;

namespace ProjectManager.Repositories;

public class ClientRepository: Repository<Client>, IClientRepository
{
    public ClientRepository(FeatureDbContext dbContext) : base(dbContext)
    {
    }
}