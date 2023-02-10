using FeatureTracker.Data;
using FeatureTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FeatureTracker.Pages.Features
{
    public class Detail : PageModel
    {
        private readonly FeatureDbContext _dbContext;

        public Feature Feature { get; set; }

        public Detail(FeatureDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task OnGet(int id)
        {
            Feature = await _dbContext.Features.FindAsync(id);
        }

        public async Task<IActionResult> OnPost(int id)
        {
            await CompleteFeature(id);

            return RedirectToPage("../Index");
        }

        private async Task CompleteFeature(int id)
        {
            var feature = _dbContext.Features.First(f => f.Id == id);

            feature.Completed = DateTime.Now;

            await _dbContext.SaveChangesAsync();
        }
    }
}