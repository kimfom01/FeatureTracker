namespace ProjectManager.Models;

public class Feature
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Completed { get; set; }
    public Priority Priority { get; set; }

    public int ProjectId { get; set; }
    public Project Project { get; set; }
}
