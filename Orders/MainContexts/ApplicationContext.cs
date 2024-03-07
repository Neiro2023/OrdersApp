using Microsoft.EntityFrameworkCore;

namespace Orders.MainContexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ClientDb> Clients { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MobilBank;Username=postgres;Password=1");
        }

    }
}
