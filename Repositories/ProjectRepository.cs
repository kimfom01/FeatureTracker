using ProjectManager.Context;
using ProjectManager.Models;

namespace ProjectManager.Repositories;

public class ProjectRepository: Repository<Project>, IProjectRepository
{
    public ProjectRepository(FeatureDbContext dbContext) : base(dbContext)
    {
    }
}