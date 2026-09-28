using ECommerceHub.Domain.Entities;
using ECommerceHub.Domain.Interfaces;
using ECommerceHub.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerceHub.Infrastructure.Repositories;

public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
{
    public InvoiceRepository(AppDbContext context) : base(context) { }

    public async Task<Invoice?> GetInvoiceByOrderIdAsync(int orderId)
        => await _dbSet.FirstOrDefaultAsync(i => i.OrderId == orderId);

    public async Task<int> GetInvoiceCountByDateAsync(DateTime date)
        => await _dbSet.CountAsync(i => i.CreatedAt.Date == date.Date);
}
