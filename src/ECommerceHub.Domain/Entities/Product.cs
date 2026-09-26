namespace ECommerceHub.Domain.Entities;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string SKU { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal CostPrice { get; set; }
    public decimal SalePrice { get; set; }
    public int StockQuantity { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<ProductMapping> ProductMappings { get; set; } = new List<ProductMapping>();
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
