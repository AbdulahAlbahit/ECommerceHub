namespace ECommerceHub.Domain.Entities;

public class Platform
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;       // Trendyol, Hepsiburada vb.
    public string BaseUrl { get; set; } = string.Empty;    // API adresi
    public string ApiKey { get; set; } = string.Empty;     // API anahtari
    public decimal CommissionRate { get; set; }             // Komisyon orani (0.15 = %15)
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Iliskiler
    public ICollection<ProductMapping> ProductMappings { get; set; } = new List<ProductMapping>();
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
