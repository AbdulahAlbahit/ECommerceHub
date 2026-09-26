namespace ECommerceHub.Domain.Entities;

public class ProductMapping
{
    public int Id { get; set; }
    public int ProductId { get; set; }                         // Merkez urun ID
    public int PlatformId { get; set; }                        // Hangi platform
    public string PlatformBarcode { get; set; } = string.Empty; // Platformdaki barkod
    public string PlatformProductId { get; set; } = string.Empty; // Platformdaki urun ID
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public Product Product { get; set; } = null!;
    public Platform Platform { get; set; } = null!;
}
