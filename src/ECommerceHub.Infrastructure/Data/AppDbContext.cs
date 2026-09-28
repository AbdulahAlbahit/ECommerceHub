using ECommerceHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace ECommerceHub.Infrastructure.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Platform> Platforms => Set<Platform>();
    public DbSet<ProductMapping> ProductMappings => Set<ProductMapping>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Order> Orders => Set<Order>();
    public DbSet<OrderItem> OrderItems => Set<OrderItem>();
    public DbSet<Invoice> Invoices => Set<Invoice>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>(e => {
            e.HasKey(p => p.Id);
            e.Property(p => p.CostPrice).HasColumnType("decimal(18,2)");
            e.Property(p => p.SalePrice).HasColumnType("decimal(18,2)");
        });
        modelBuilder.Entity<Platform>(e => {
            e.HasKey(p => p.Id);
            e.Property(p => p.CommissionRate).HasColumnType("decimal(5,4)");
        });
        modelBuilder.Entity<ProductMapping>(e => {
            e.HasKey(pm => pm.Id);
            e.HasIndex(pm => new { pm.ProductId, pm.PlatformId }).IsUnique();
            e.HasOne(pm => pm.Product).WithMany(p => p.ProductMappings).HasForeignKey(pm => pm.ProductId);
            e.HasOne(pm => pm.Platform).WithMany(p => p.ProductMappings).HasForeignKey(pm => pm.PlatformId);
        });
        modelBuilder.Entity<Order>(e => {
            e.HasKey(o => o.Id);
            e.Property(o => o.TotalAmount).HasColumnType("decimal(18,2)");
            e.HasOne(o => o.Platform).WithMany(p => p.Orders).HasForeignKey(o => o.PlatformId);
            e.HasOne(o => o.Customer).WithMany(c => c.Orders).HasForeignKey(o => o.CustomerId);
        });
        modelBuilder.Entity<OrderItem>(e => {
            e.HasKey(oi => oi.Id);
            e.Property(oi => oi.UnitPrice).HasColumnType("decimal(18,2)");
            e.Property(oi => oi.CostPrice).HasColumnType("decimal(18,2)");
            e.Property(oi => oi.CommissionAmount).HasColumnType("decimal(18,2)");
            e.Property(oi => oi.NetProfit).HasColumnType("decimal(18,2)");
            e.HasOne(oi => oi.Order).WithMany(o => o.OrderItems).HasForeignKey(oi => oi.OrderId);
            e.HasOne(oi => oi.Product).WithMany(p => p.OrderItems).HasForeignKey(oi => oi.ProductId);
        });
        modelBuilder.Entity<Invoice>(e => {
            e.HasKey(i => i.Id);
            e.Property(i => i.TotalAmount).HasColumnType("decimal(18,2)");
            e.HasOne(i => i.Order).WithOne(o => o.Invoice).HasForeignKey<Invoice>(i => i.OrderId);
        });
    }
}
