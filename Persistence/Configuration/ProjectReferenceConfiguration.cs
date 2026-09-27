using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refolio.Models;

namespace Refolio.Persistence.Configuration;

public class ProjectReferenceConfiguration: IEntityTypeConfiguration<ProjectReference>
{
    public void Configure(EntityTypeBuilder<ProjectReference> builder)
    {
        builder.ToTable("Project_references");

        builder.HasKey(m => m.Id);
        
        builder.HasOne(m => m.Project)
            .WithMany().
            HasForeignKey(m => m.ProjectId).OnDelete(DeleteBehavior.Restrict);;
        
        builder.HasOne(m => m.Backlog)
            .WithMany().
            HasForeignKey(m => m.BacklogId).OnDelete(DeleteBehavior.Restrict);;
        
        builder.Property(m=> m.CreatedAt).IsRequired().ValueGeneratedOnAdd();
        builder.Property(m=> m.UpdatedAt).IsRequired().ValueGeneratedOnAddOrUpdate();
    }
}