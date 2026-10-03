namespace Refolio.Models;

public class EntityBase
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; private set; } =  DateTime.UtcNow;

    public void UpdateLastModified()
    {
        UpdatedAt = DateTime.UtcNow;
    }
}