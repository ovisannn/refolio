using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refolio.Models;

namespace Refolio.Persistence.Configuration;

public class AnnotationCofiguration : IEntityTypeConfiguration<Annotation>
{
    public void Configure(EntityTypeBuilder<Annotation> builder)
    {
        builder.ToTable("Annotations");
        builder.HasKey(m => m.Id);
        
        builder.HasOne(m => m.ProjectReference).WithMany().HasForeignKey(m => m.ProjectReferenceId)
            .OnDelete(DeleteBehavior.Restrict);;
        
        builder.Property(m => m.Summary).HasColumnType("text");
        builder.Property(m => m.Evaluation).HasColumnType("text");
        builder.Property(m => m.Relevance).HasColumnType("text");
        builder.Property(m => m.Notes).HasColumnType("text");
        
        builder.Property(m => m.CreatedAt).IsRequired().ValueGeneratedOnAdd();
        builder.Property(m => m.UpdatedAt).IsRequired().ValueGeneratedOnAddOrUpdate();
    }
}