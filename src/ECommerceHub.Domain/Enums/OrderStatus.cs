namespace ECommerceHub.Domain.Enums;

public enum OrderStatus
{
    Pending = 0,      // Bekliyor
    Processing = 1,   // Isleniyor
    Completed = 2,    // Tamamlandi
    Cancelled = 3,    // Iptal edildi
    Refunded = 4      // Iade edildi
}
