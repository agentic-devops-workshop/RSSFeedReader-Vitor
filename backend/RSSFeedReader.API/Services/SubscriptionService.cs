namespace RSSFeedReader.API.Services;

using RSSFeedReader.API.Models;

public interface ISubscriptionService
{
    Task<Subscription> AddSubscriptionAsync(string url);
    Task<IEnumerable<Subscription>> GetAllSubscriptionsAsync();
}

public class SubscriptionService : ISubscriptionService
{
    private readonly List<Subscription> _subscriptions = new();
    private readonly object _lock = new();

    public Task<Subscription> AddSubscriptionAsync(string url)
    {
        lock (_lock)
        {
            var subscription = new Subscription
            {
                Id = Guid.NewGuid(),
                Url = url
            };
            _subscriptions.Add(subscription);
            return Task.FromResult(subscription);
        }
    }

    public Task<IEnumerable<Subscription>> GetAllSubscriptionsAsync()
    {
        lock (_lock)
        {
            return Task.FromResult(_subscriptions.AsEnumerable());
        }
    }
}
