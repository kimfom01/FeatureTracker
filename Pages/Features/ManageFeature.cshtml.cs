using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Features;

public class ManageFeature : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public ManageFeature(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [BindProperty]
    public IEnumerable<Feature>? Features { get; set; }

    public void OnGet()
    {
        Features = _unitOfWork.Features.GetAll()
            .Where(f => f.Completed == null)
            .OrderByDescending(f => f.Priority)
            .ThenByDescending(f => f.Created);
    }
}