
namespace GymManagement.Domain.Subscriptions.Repositories;

public interface ISubscriptionsRepository
{
    Task Add(Subscription subscription);
    Task<Subscription?> GetById(Guid id);
}
