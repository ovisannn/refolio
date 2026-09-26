namespace Refolio.Models;

public class Backlog
{
    public required long id { get; set; }
    public required long UserId { get; set; }
    public required long DocumentId { get; set; }
    public required ReadingStatus ReadingStatus { get; set; }
    public required int Priority { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime UpdatedAt { get; set; }
    public required string Notes { get; set; }
}

public enum ReadingStatus
{
    Untouched,
    OnHold,
    OnProgress,
    Completed,
}