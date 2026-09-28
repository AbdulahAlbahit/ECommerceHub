using ECommerceHub.Domain.Entities;
using ECommerceHub.Domain.Interfaces;
using ECommerceHub.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerceHub.Infrastructure.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(AppDbContext context) : base(context) { }

    public async Task<Product?> GetProductBySKUAsync(string sku)
        => await _dbSet.FirstOrDefaultAsync(p => p.SKU == sku);

    public async Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold)
        => await _dbSet.Where(p => p.StockQuantity <= threshold).ToListAsync();
}
