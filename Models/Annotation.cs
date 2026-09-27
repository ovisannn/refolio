namespace Refolio.Models;

public class Annotation : EntityBase
{
    public long ProjectReferenceId { get; set; }
    public ProjectReference ProjectReference { get; set; } = null!;
    
    public required string Summary { get; set; }
    public required string Evaluation { get; set; }
    public required string Relevance { get; set; }
    public required string Notes { get; set; }
}