using ECommerceHub.Domain.Enums;

namespace ECommerceHub.Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public int PlatformId { get; set; }                        // Hangi platformdan geldi
    public string PlatformOrderId { get; set; } = string.Empty; // Platformun kendi siparis ID si
    public int CustomerId { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
    public decimal TotalAmount { get; set; }                   // Toplam tutar
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public Platform Platform { get; set; } = null!;
    public Customer Customer { get; set; } = null!;
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    public Invoice? Invoice { get; set; }
}
