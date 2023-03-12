using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Features;

public class NewFeature : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    [BindProperty]
    public Feature Feature { get; set; }

    public NewFeature(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        await _unitOfWork.Features.AddAsync(Feature);
        await _unitOfWork.SaveChanges();

        return RedirectToPage("/Features/ManageFeature");
    }
}
