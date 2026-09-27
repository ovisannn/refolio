using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refolio.Models;

namespace Refolio.Persistence.Configuration;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.ToTable("Projects");
        
        builder.HasKey(m => m.Id);
        builder.HasOne(m => m.User).WithMany().HasForeignKey(m => m.UserId)
            .OnDelete(DeleteBehavior.Restrict);;
        
        builder.Property(m => m.Title).IsRequired().HasMaxLength(300);
        builder.Property(m => m.Description).IsRequired();
        
        builder.Property(m => m.CreatedAt).IsRequired().ValueGeneratedOnAdd();
        builder.Property(m => m.UpdatedAt).IsRequired().ValueGeneratedOnAddOrUpdate();
        
        builder.HasIndex(m => m.Title);
    }
}