using System;

namespace Refolio.Models;

public class Backlog: EntityBase
{
    
    public long UserId { get; set; }
    public User User { get; set; } = null!;
    
    public long DocumentId { get; set; }
    public Document Document { get; set; } = null!;
    public string? Notes { get; set; }
    
    public required ReadingStatus ReadingStatus { get; set; }
    public int? Priority { get; set; }
    public DateTime? CompletedAt { get; set; }
}

public enum ReadingStatus
{
    Untouched,
    OnHold,
    OnProgress,
    Completed,
}