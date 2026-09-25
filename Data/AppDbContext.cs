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
    }
}
