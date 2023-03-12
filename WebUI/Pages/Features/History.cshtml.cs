using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebUI.Models;
using WebUI.Repositories;

namespace WebUI.Pages.Features;

public class History : PageModel
{
    private readonly IFeatureRepository _featureRepository;

    [BindProperty]
    public IEnumerable<Feature> Features { get; set; } = Enumerable.Empty<Feature>();

    public History(IFeatureRepository featureRepository)
    {
        _featureRepository = featureRepository;
    }

    public void OnGet()
    {
        var features = _featureRepository.GetAll();

        Features = _featureRepository.GetAll()
            .Where(f => f.Completed != null)
            .OrderByDescending(f => f.Completed);
    }
}
