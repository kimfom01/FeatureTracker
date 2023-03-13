using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Projects;

public class Detail : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public Detail(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Project? Project { get; set; }
    
    public async Task OnGet(int id)
    {
        Project = await _unitOfWork.Projects.FindAsync(id);
    }
}