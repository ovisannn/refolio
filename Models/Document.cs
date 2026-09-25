using System.Runtime.InteropServices.JavaScript;

namespace Refolio.Models;

public class Document
{
    public required long Id { get; set; }
    public required string Title { get; set; }
    public required string[] Authors { get; set; }
    public required DocType Type { get; set; }
    public required int PublicationYear { get; set; }
    public required string Doi {get; set;}
    public required string Isbn { get; set; }
    public required string Publisher { get; set; }
    public required string Url { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}

public enum DocType
{
    Journal,
    Book,
    Conference,
    Thesis,
    Dissertation,
    Report,
    Website,
    Dataset,
    Preprint,
    BookChapter,
    Standard,
    Patent,
    Other
}