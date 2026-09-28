using ECommerceHub.Domain.Entities;
using ECommerceHub.Domain.Interfaces;
using ECommerceHub.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ECommerceHub.Infrastructure.Repositories;

public class PlatformRepository : Repository<Platform>, IPlatformRepository
{
    public PlatformRepository(AppDbContext context) : base(context) { }

    public async Task<IEnumerable<Platform>> GetActivePlatformsAsync()
        => await _dbSet.Where(p => p.IsActive).ToListAsync();
}
