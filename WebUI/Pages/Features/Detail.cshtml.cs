using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebUI.Models;
using WebUI.Repositories;

namespace WebUI.Pages.Features
{
    public class Detail : PageModel
    {
        private readonly IFeatureRepository _featureRepository;

        public Feature Feature { get; set; }

        public Detail(IFeatureRepository featureRepository)
        {
            _featureRepository = featureRepository;
        }

        public async Task OnGet(int id)
        {
            Feature = await _featureRepository.FindAsync(id);
        }

        public async Task<IActionResult> OnPost(int id)
        {
            await CompleteFeature(id);

            return RedirectToPage("../Index");
        }

        private async Task CompleteFeature(int id)
        {
            var feature = await _featureRepository.FindAsync(id);

            feature.Completed = DateTime.Now;

            await _featureRepository.SaveChangesAsync();
        }
    }
}