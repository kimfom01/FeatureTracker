using Data.Models;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FeatureTracker.Pages;

public class IndexModel : PageModel
{
    private readonly IFeatureRepository _featureRepository;

    public IndexModel(IFeatureRepository featureRepository)
    {
        _featureRepository = featureRepository;
    }

    [BindProperty]
    public IEnumerable<Feature> Features { get; set; } = Enumerable.Empty<Feature>();

    public void OnGet()
    {
        Features = _featureRepository.GetAll()
            .Where(f => f.Completed == null)
            .OrderByDescending(f => f.Priority)
            .ThenByDescending(f => f.Created);
    }
}
