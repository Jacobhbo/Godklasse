using Microsoft.EntityFrameworkCore;

namespace Godklasse.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }
        public DbSet<User> Users { get; set; }
    }
    // Define DbSet properties for your entities (tables)
}
