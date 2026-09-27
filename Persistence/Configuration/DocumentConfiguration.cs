using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refolio.Models;

namespace Refolio.Persistence.Configuration;

public class DocumentConfiguration : IEntityTypeConfiguration<Document>
{
    public void Configure(EntityTypeBuilder<Document> builder)
    {
        builder.ToTable("Documents");
        
        builder.HasKey(m => m.Id);
        
        builder.Property(m => m.Title).IsRequired();
        builder.Property(m => m.Authors).IsRequired();
        builder.Property(m => m.Type).IsRequired().HasConversion<string>();
        builder.Property(m => m.PublicationYear);

        builder.Property(m => m.Doi);
        builder.Property(m => m.Isbn);
        builder.Property(m => m.Publisher);
        builder.Property(m => m.Url);

        builder.Property(m => m.CreatedAt).IsRequired().ValueGeneratedOnAdd();
        builder.Property(m => m.UpdatedAt).IsRequired().ValueGeneratedOnAddOrUpdate();
        
        builder.HasIndex(m => m.Title);
    }
}