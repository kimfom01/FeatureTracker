using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Clients;

public class NewClient : PageModel
{
    private readonly IClientRepository _clientRepository;

    public NewClient(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }
    
    [BindProperty] 
    public Client Client { get; set; }
    
    public async Task<IActionResult> OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        await _clientRepository.AddAsync(Client);
        await _clientRepository.SaveChangesAsync();

        return RedirectToPage("/Clients/ManageClient");
    }
}