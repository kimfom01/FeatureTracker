using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectManager.Models;
using ProjectManager.Repositories;

namespace ProjectManager.Pages.Clients;

public class ManageClient : PageModel
{
    private readonly IClientRepository _clientRepository;

    public ManageClient(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    [BindProperty]
    public IEnumerable<Client>? Clients { get; set; }
    
    public void OnGet()
    {
        Clients = _clientRepository.GetAll();
    }
}