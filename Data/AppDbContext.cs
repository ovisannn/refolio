using Microsoft.EntityFrameworkCore;
using Refolio.Models;

namespace Refolio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        
        }
    
        public DbSet<User> Users { get; set; }
        public DbSet<ProjectReference> ProjectReferences { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Backlog> Backlogs { get; set; }
        public DbSet<Annotation> Annotations { get; set; }
    }
}
