using GymManagement.Domain.Subscriptions;
using GymManagement.Domain.Subscriptions.Repositories;
using GymManagement.Infrastructure.Common.Persistence;

namespace GymManagement.Infrastructure.Subscriptions.Persistence;
public sealed class SubscriptionsRepository : ISubscriptionsRepository
{
    private readonly GymManagementDbContext _dbContext;

    public SubscriptionsRepository(GymManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Add(Subscription subscription)
    {
        await _dbContext.Subscriptions.AddAsync(subscription);
    }

    public async Task<Subscription?> GetById(Guid id)
    {
        return await _dbContext.Subscriptions.FindAsync(id);
    }
}
