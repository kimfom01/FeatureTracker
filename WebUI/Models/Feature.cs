namespace WebUI.Models;

public class Feature
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Created { get; set; }
    public DateTime? Completed { get; set; }
    public Priority Priority { get; set; }
}
