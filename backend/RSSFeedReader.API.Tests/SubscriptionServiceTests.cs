namespace RSSFeedReader.API.Tests;

using Xunit;
using RSSFeedReader.API.Services;

public class SubscriptionServiceTests
{
    [Fact]
    public async Task AddSubscriptionAsync_WithValidUrl_ReturnsSubscription()
    {
        // Arrange
        var service = new SubscriptionService();
        var testUrl = "https://example.com/feed";

        // Act
        var result = await service.AddSubscriptionAsync(testUrl);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(testUrl, result.Url);
        Assert.NotEqual(Guid.Empty, result.Id);
    }

    [Fact]
    public async Task GetAllSubscriptionsAsync_AfterAddingSubscription_ReturnsSubscription()
    {
        // Arrange
        var service = new SubscriptionService();
        var testUrl = "https://example.com/feed";
        await service.AddSubscriptionAsync(testUrl);

        // Act
        var results = await service.GetAllSubscriptionsAsync();

        // Assert
        Assert.NotNull(results);
        Assert.Single(results);
        Assert.Equal(testUrl, results.First().Url);
    }

    [Fact]
    public async Task GetAllSubscriptionsAsync_InitiallyEmpty_ReturnsEmptyList()
    {
        // Arrange
        var service = new SubscriptionService();

        // Act
        var results = await service.GetAllSubscriptionsAsync();

        // Assert
        Assert.NotNull(results);
        Assert.Empty(results);
    }

    [Fact]
    public async Task AddSubscriptionAsync_MultipleSubscriptions_ReturnsAll()
    {
        // Arrange
        var service = new SubscriptionService();
        var urls = new[] 
        { 
            "https://example.com/feed1",
            "https://example.com/feed2",
            "https://example.com/feed3"
        };

        // Act
        foreach (var url in urls)
        {
            await service.AddSubscriptionAsync(url);
        }

        var results = await service.GetAllSubscriptionsAsync();

        // Assert
        Assert.NotNull(results);
        Assert.Equal(3, results.Count());
    }
}
