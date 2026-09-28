using ECommerceHub.Domain.Entities;

namespace ECommerceHub.Domain.Interfaces;

public interface IProductMappingRepository : IRepository<ProductMapping>
{
    Task<ProductMapping?> GetMappingByPlatformBarcodeAsync(int platformId, string barcode);
    Task<IEnumerable<ProductMapping>> GetMappingsByProductIdAsync(int productId);
    Task<IEnumerable<ProductMapping>> GetMappingsByPlatformIdAsync(int platformId);
}
