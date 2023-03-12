using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Clients;

public class ManageClient : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public ManageClient(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [BindProperty]
    public IEnumerable<Client>? Clients { get; set; }
    
    public void OnGet()
    {
        Clients = _unitOfWork.Clients.GetAll();
    }
}