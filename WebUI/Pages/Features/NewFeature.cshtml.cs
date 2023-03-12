using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebUI.Models;
using WebUI.Repositories;

namespace WebUI.Pages.Features;

public class NewFeature : PageModel
{
    private readonly IFeatureRepository _featureRepository;

    [BindProperty]
    public Feature Feature { get; set; }

    public NewFeature(IFeatureRepository featureRepository)
    {
        _featureRepository = featureRepository;
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        await _featureRepository.AddAsync(Feature);
        await _featureRepository.SaveChangesAsync();

        return RedirectToPage("../Index");
    }
}
