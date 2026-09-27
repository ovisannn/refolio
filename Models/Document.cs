namespace Refolio.Models;

public class Document: EntityBase
{
    public required string Title { get; set; }
    public required string[] Authors { get; set; }
    public DocType Type { get; set; }
    public int? PublicationYear { get; set; }
    
    public string? Doi {get; set;}
    public string? Isbn { get; set; }
    public string? Publisher { get; set; }
    public string? Url { get; set; }
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