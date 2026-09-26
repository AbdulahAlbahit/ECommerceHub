namespace ECommerceHub.Domain.Entities;
public class ProductMapping
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int PlatformId { get; set; }
    public string PlatformBarcode { get; set; } = string.Empty;
    public string PlatformProductId { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public Product Product { get; set; } = null!;
    public Platform Platform { get; set; } = null!;
}
