using Microsoft.EntityFrameworkCore;
using WebVerduleros.Models;

namespace WebVerduleros.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Verduras>Verduras { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {
        }

    }
}
