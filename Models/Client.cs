namespace ProjectManager.Models;

public class Client
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public ICollection<Project> Projects { get; set; }
}