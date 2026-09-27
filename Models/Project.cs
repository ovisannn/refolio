namespace Refolio.Models;

public class Project : EntityBase
{
    public long UserId { get; set; }
    public User User { get; set; }  = null!;
    
    public required string Title { get; set; }
    public string? Description { get; set; }
}