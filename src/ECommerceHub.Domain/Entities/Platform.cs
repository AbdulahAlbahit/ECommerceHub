namespace ECommerceHub.Domain.Entities;
public class Platform
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string BaseUrl { get; set; } = string.Empty;
    public string ApiKey { get; set; } = string.Empty;
    public decimal CommissionRate { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public ICollection<ProductMapping> ProductMappings { get; set; } = new List<ProductMapping>();
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
