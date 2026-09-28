using ECommerceHub.Domain.Entities;

namespace ECommerceHub.Domain.Interfaces;

public interface ICustomerRepository : IRepository<Customer>
{
    Task<Customer?> GetCustomerByEmailAsync(string email);
}
