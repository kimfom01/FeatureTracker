using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Features;

public class History : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    [BindProperty]
    public IEnumerable<Feature>? Features { get; set; }

    public History(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public void OnGet()
    {
        Features = _unitOfWork.Features.GetAll()
            .Where(f => f.Completed != null)
            .OrderByDescending(f => f.Completed);
    }
}
