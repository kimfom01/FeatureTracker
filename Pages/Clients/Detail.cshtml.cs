using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Clients;

public class Detail : PageModel
{
    private readonly IClientRepository _clientRepository;

    public Detail(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public Client? Client { get; set; }
    
    public async Task OnGet(int id)
    {
        Client = await _clientRepository.FindAsync(id);
    }
}