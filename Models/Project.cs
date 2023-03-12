namespace ProjectManager.Models;

public class Project
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public Status Status { get; set; }
    public Priority Priority { get; set; }
    public string? Requirements { get; set; }
    public decimal Budget { get; set; }
    public DateTime Deadline { get; set; }

    public int ClientId { get; set; }
    public Client Client { get; set; }
    public ICollection<Feature> Features { get; set; }
}