using ECommerceHub.Domain.Entities;

namespace ECommerceHub.Domain.Interfaces;

public interface IProductRepository : IRepository<Product>
{
    Task<Product?> GetProductBySKUAsync(string sku);
    Task<IEnumerable<Product>> GetLowStockProductsAsync(int threshold);
}
