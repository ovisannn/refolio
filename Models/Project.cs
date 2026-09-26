namespace Refolio.Models;

public class Project
{
    public required long Id { get; set; }
    public required long UserId { get; set; }
    public required string Title { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }
}