using Microsoft.EntityFrameworkCore;

namespace ECommerceHub.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Entity konfigurasyonlari ilerleyen asama2da eklenecek
    }
}
