using FeatureTracker.Data;
using FeatureTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FeatureTracker.Pages.Features;

public class History : PageModel
{
    private readonly FeatureDbContext _dbContext;

    [BindProperty]
    public IEnumerable<Feature> Features { get; set; } = Enumerable.Empty<Feature>();

    public History(FeatureDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task OnGet()
    {
        Features = await _dbContext.Features
            .Where(f => f.Completed != null)
            .OrderByDescending(f => f.Completed)
            .ToListAsync();
    }
}