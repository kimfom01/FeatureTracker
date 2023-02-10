using FeatureTracker.Data;
using FeatureTracker.Models;

namespace FeatureTracker.Repositories;

public class FeatureRepository : Repository<Feature>, IFeatureRepository
{
    public FeatureRepository(FeatureDbContext dbContext) : base(dbContext)
    {
    }
}
