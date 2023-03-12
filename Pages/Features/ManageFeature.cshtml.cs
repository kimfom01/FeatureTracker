using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Features;

public class ManageFeature : PageModel
{
    private readonly IFeatureRepository _featureRepository;

    public ManageFeature(IFeatureRepository featureRepository)
    {
        _featureRepository = featureRepository;
    }

    [BindProperty]
    public IEnumerable<Feature>? Features { get; set; }

    public void OnGet()
    {
        Features = _featureRepository.GetAll()
            .Where(f => f.Completed == null)
            .OrderByDescending(f => f.Priority)
            .ThenByDescending(f => f.Created);
    }
}