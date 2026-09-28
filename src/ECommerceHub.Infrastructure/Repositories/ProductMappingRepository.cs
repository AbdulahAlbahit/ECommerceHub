using ECommerceHub.Domain.Entities;
using ECommerceHub.Domain.Interfaces;
using ECommerceHub.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerceHub.Infrastructure.Repositories;

public class ProductMappingRepository : Repository<ProductMapping>, IProductMappingRepository
{
    public ProductMappingRepository(AppDbContext context) : base(context) { }

    public async Task<ProductMapping?> GetMappingByPlatformBarcodeAsync(int platformId, string barcode)
        => await _dbSet
            .Include(pm => pm.Product)
            .Include(pm => pm.Platform)
            .FirstOrDefaultAsync(pm => pm.PlatformId == platformId && pm.PlatformBarcode == barcode);

    public async Task<IEnumerable<ProductMapping>> GetMappingsByProductIdAsync(int productId)
        => await _dbSet
            .Include(pm => pm.Platform)
            .Where(pm => pm.ProductId == productId)
            .ToListAsync();

    public async Task<IEnumerable<ProductMapping>> GetMappingsByPlatformIdAsync(int platformId)
        => await _dbSet
            .Include(pm => pm.Product)
            .Where(pm => pm.PlatformId == platformId)
            .ToListAsync();
}
