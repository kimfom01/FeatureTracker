using FeatureTracker.Data;
using FeatureTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FeatureTracker.Pages.Features;

public class NewFeature : PageModel
{
    private readonly FeatureDbContext _dbContext;

    [BindProperty]
    public Feature Feature { get; set; }

    public NewFeature(FeatureDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        await _dbContext.AddAsync(Feature);
        await _dbContext.SaveChangesAsync();

        return RedirectToPage("../Index");
    }
}
