using Data.Context;
using Data.Models;

namespace Data.Repositories;

public class FeatureRepository : Repository<Feature>, IFeatureRepository
{
    public FeatureRepository(FeatureDbContext dbContext) : base(dbContext)
    {
    }
}
