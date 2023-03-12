using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Clients;

public class NewClient : PageModel
{
    private readonly IUnitOfWork _unitOfWork;

    public NewClient(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    [BindProperty] 
    public Client Client { get; set; }
    
    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        await _unitOfWork.Clients.AddAsync(Client);
        await _unitOfWork.SaveChanges();

        return RedirectToPage("/Clients/ManageClient");
    }
}