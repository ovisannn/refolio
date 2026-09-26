namespace Refolio.Models;

public class ProjectReference
{
    public required long Id { get; set; }
    public required long ProjectId { get; set; }
    public required long BacklogId { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }
}