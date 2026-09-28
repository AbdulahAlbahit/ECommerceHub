using ECommerceHub.Domain.Entities;

namespace ECommerceHub.Domain.Interfaces;

public interface IInvoiceRepository : IRepository<Invoice>
{
    Task<Invoice?> GetInvoiceByOrderIdAsync(int orderId);
    Task<int> GetInvoiceCountByDateAsync(DateTime date);
}
