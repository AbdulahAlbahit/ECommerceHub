using ECommerceHub.Domain.Entities;

namespace ECommerceHub.Domain.Interfaces;

public interface IPlatformRepository : IRepository<Platform>
{
    Task<IEnumerable<Platform>> GetActivePlatformsAsync();
}
