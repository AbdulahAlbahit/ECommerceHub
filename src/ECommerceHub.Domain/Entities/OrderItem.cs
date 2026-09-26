namespace ECommerceHub.Domain.Entities;

public class OrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }                // Satis birim fiyati
    public decimal CostPrice { get; set; }                // Maliyet birim fiyati (karin hesabi icin)
    public decimal CommissionAmount { get; set; }         // Platform komisyon tutari
    public decimal NetProfit { get; set; }                // Net kar = UnitPrice - CostPrice - Commission

    // Navigation properties
    public Order Order { get; set; } = null!;
    public Product Product { get; set; } = null!;
}
