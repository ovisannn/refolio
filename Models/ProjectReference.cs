namespace Refolio.Models;

public class ProjectReference: EntityBase
{
    public long ProjectId { get; set; }
    public Project Project { get; set; } = null!;
    
    public long BacklogId { get; set; }
    public Backlog Backlog { get; set; } = null!;
}