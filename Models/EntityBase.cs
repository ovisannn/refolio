using System;

namespace Refolio.Models;

public class EntityBase
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}