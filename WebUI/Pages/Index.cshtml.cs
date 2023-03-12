using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebUI.Models;
using WebUI.Repositories;

namespace WebUI.Pages;

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
