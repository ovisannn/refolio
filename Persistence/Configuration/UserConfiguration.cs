using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Refolio.Models;

namespace Refolio.Persistence.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(m => m.Id);
        builder.Property(m => m.Id).ValueGeneratedOnAdd();
        
        builder.Property(m=> m.Username).IsRequired().HasMaxLength(200);
        builder.Property(m=> m.Password).IsRequired().HasMaxLength(200);
        builder.Property(m=> m.Email).IsRequired().HasMaxLength(200);
        
        builder.Property(m=> m.CreatedAt).IsRequired().ValueGeneratedOnAdd();
        builder.Property(m=> m.UpdatedAt).IsRequired().ValueGeneratedOnAddOrUpdate();
        
        builder.HasIndex(m=> m.Username);
        builder.HasIndex(m=> m.Email);
    }
}