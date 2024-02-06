using ErrorOr;
using GymManagement.Domain.Subscriptions;
using GymManagement.Domain.Subscriptions.Repositories;
using MediatR;

namespace GymManagement.Application.Subscriptions.Queries.GetSubscription;

public sealed class GetSubscriptionQueryHandler : IRequestHandler<GetSubscriptionQuery, ErrorOr<Subscription>>
{
    private readonly ISubscriptionsRepository _subscriptionsRepository;

    public GetSubscriptionQueryHandler(ISubscriptionsRepository subscriptionsRepository)
    {
        _subscriptionsRepository = subscriptionsRepository;
    }

    public async Task<ErrorOr<Subscription>> Handle(GetSubscriptionQuery request, CancellationToken cancellationToken)
    {
        var subscription = await _subscriptionsRepository.GetById(request.Id);

        return subscription is null
            ? Error.NotFound(description: "Subscription doesn't exists.")
            : subscription;
    }
}
