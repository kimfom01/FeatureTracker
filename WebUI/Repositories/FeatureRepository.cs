using WebUI.Context;
using WebUI.Models;

namespace WebUI.Repositories;

public class FeatureRepository : Repository<Feature>, IFeatureRepository
{
    public FeatureRepository(FeatureDbContext dbContext) : base(dbContext)
    {
    }
}
