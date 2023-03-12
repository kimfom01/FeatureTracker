using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Features;

public class Detail : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public Feature? Feature { get; set; }

    public Detail(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task OnGet(int id)
    {
        Feature = await _unitOfWork.Features.FindAsync(id);
    }

    public async Task<IActionResult> OnPost(int id)
    {
        await CompleteFeature(id);

        return RedirectToPage("../Index");
    }

    private async Task CompleteFeature(int id)
    {
        var feature = await _unitOfWork.Features.FindAsync(id);

        if (feature is not null)
        {
            feature.Completed = DateTime.Now;
            
            await _unitOfWork.SaveChanges();
        }
    }
}