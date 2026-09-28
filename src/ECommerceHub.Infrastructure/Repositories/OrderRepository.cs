using ECommerceHub.Domain.Entities;
using ECommerceHub.Domain.Interfaces;
using ECommerceHub.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerceHub.Infrastructure.Repositories;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    public OrderRepository(AppDbContext context) : base(context) { }

    public async Task<Order?> GetOrderByPlatformOrderIdAsync(int platformId, string platformOrderId)
        => await _dbSet
            .Include(o => o.OrderItems)
            .FirstOrDefaultAsync(o => o.PlatformId == platformId && o.PlatformOrderId == platformOrderId);

    public async Task<Order?> GetOrderWithDetailsAsync(int orderId)
        => await _dbSet
            .Include(o => o.Customer)
            .Include(o => o.Platform)
            .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
            .Include(o => o.Invoice)
            .FirstOrDefaultAsync(o => o.Id == orderId);

    public async Task<IEnumerable<Order>> GetOrdersByPlatformAsync(int platformId)
        => await _dbSet
            .Include(o => o.Customer)
            .Where(o => o.PlatformId == platformId)
            .ToListAsync();

    public async Task<IEnumerable<Order>> GetOrdersByDateRangeAsync(DateTime startDate, DateTime endDate)
        => await _dbSet
            .Include(o => o.Customer)
            .Include(o => o.Platform)
            .Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
            .ToListAsync();
}
