using Karaoke.Domain.Models.Players;
using Karaoke.Domain.Models.Karaoke;
using Microsoft.EntityFrameworkCore;

namespace Karaoke.Domain.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Karaoke.db;");
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Karaokes> Karaokes { get; set; }

    }
}
