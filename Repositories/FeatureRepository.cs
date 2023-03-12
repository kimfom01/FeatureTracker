using ProjectManager.Context;
using ProjectManager.Models;

namespace ProjectManager.Repositories;

public class FeatureRepository : Repository<Feature>, IFeatureRepository
{
    public FeatureRepository(FeatureDbContext dbContext) : base(dbContext)
    {
    }
}
