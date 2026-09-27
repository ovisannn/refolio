using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refolio.Models;

namespace Refolio.Persistence.Configuration;

public class BacklogConfiguration : IEntityTypeConfiguration<Backlog>
{
    public void Configure(EntityTypeBuilder<Backlog> builder)
    {
        builder.ToTable("Backlog");
        builder.HasKey(m => m.Id);

        builder.HasOne(m => m.User).WithMany().HasForeignKey(m => m.UserId)
            .OnDelete(DeleteBehavior.Restrict);;
        builder.HasOne(m => m.Document).WithMany().HasForeignKey(m => m.DocumentId)
            .OnDelete(DeleteBehavior.Restrict);;
        
        builder.Property(m => m.Notes).HasColumnType("text");
        builder.Property(m => m.ReadingStatus).HasConversion<string>();
        builder.Property(m => m.Priority);
        builder.Property(m => m.CompletedAt);
        
        builder.Property(m => m.CreatedAt).IsRequired().ValueGeneratedOnAdd();
        builder.Property(m => m.UpdatedAt).IsRequired().ValueGeneratedOnAddOrUpdate();
    }
}