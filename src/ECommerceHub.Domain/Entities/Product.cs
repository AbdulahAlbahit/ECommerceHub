namespace ECommerceHub.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string SKU { get; set; } = string.Empty;        // Stok kodu
    public string Description { get; set; } = string.Empty;
    public decimal CostPrice { get; set; }                 // Alis fiyati (maliyet)
    public decimal SalePrice { get; set; }                 // Satis fiyati
    public int StockQuantity { get; set; }                 // Mevcut stok
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // Iliskiler
    public ICollection<ProductMapping> ProductMappings { get; set; } = new List<ProductMapping>();
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
