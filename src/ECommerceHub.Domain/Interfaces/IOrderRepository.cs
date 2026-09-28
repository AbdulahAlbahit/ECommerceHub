using ECommerceHub.Domain.Entities;

namespace ECommerceHub.Domain.Interfaces;

public interface IOrderRepository : IRepository<Order>
{
    Task<Order?> GetOrderByPlatformOrderIdAsync(int platformId, string platformOrderId);
    Task<Order?> GetOrderWithDetailsAsync(int orderId);
    Task<IEnumerable<Order>> GetOrdersByPlatformAsync(int platformId);
    Task<IEnumerable<Order>> GetOrdersByDateRangeAsync(DateTime startDate, DateTime endDate);
}
