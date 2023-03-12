using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Clients;

public class Detail : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public Detail(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Client? Client { get; set; }
    
    public async Task OnGet(int id)
    {
        Client = await _unitOfWork.Clients.FindAsync(id);
    }
}