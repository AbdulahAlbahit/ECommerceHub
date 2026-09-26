namespace ECommerceHub.Domain.Entities;

public class Invoice
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public string InvoiceNumber { get; set; } = string.Empty;  // Ornek: INV-20250923-001
    public string PdfPath { get; set; } = string.Empty;        // wwwroot/invoices/xxx.pdf
    public decimal TotalAmount { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public Order Order { get; set; } = null!;
}
