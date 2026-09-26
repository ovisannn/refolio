namespace Refolio.Models;

public class Annotation
{
    public required long Id { get; set; }
    public required long ProjectId { get; set; }
    public required string Summary { get; set; }
    public required string Evaluation { get; set; }
    public required string Relevance { get; set; }
    public required string Notes { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }
}