using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Projects;

public class NewProject : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public NewProject(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [BindProperty]
    public Project Project { get; set; }
    
    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        await _unitOfWork.Projects.AddAsync(Project);
        await _unitOfWork.SaveChanges();

        return RedirectToPage("/Projects/ManageProject");
    }
}