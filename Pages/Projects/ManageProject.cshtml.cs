using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Projects;

public class ManageProject : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public ManageProject(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IEnumerable<Project>? Projects { get; set; }
    
    public void OnGet()
    {
        Projects = _unitOfWork.Projects.GetAll();
    }
}