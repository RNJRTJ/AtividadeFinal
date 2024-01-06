using Games.Model;
using Microsoft.EntityFrameworkCore;

namespace Games.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }
        public DbSet<Contato> Contato { get; set; }
    }
}
