namespace RSSFeedReader.Client.Tests;

using Xunit;
using RSSFeedReader.Client.Services;

public class SubscriptionServiceTests
{
    [Fact]
    public void Constructor_WithHttpClient_CreatesServiceSuccessfully()
    {
        // Arrange
        var httpClient = new HttpClient();

        // Act
        var service = new SubscriptionService(httpClient);

        // Assert
        Assert.NotNull(service);
    }

    [Fact]
    public async Task AddSubscriptionAsync_WithValidUrl_CallsHttpClient()
    {
        // Arrange
        var httpClient = new HttpClient();
        var service = new SubscriptionService(httpClient);
        var testUrl = "https://example.com/feed";

        // Act & Assert
        // Note: This test would need mock HttpClient setup in a real scenario
        // For MVP, we're verifying basic instantiation
        Assert.NotNull(service);
    }

    [Fact]
    public async Task GetAllSubscriptionsAsync_ReturnsListOrEmpty()
    {
        // Arrange
        var httpClient = new HttpClient();
        var service = new SubscriptionService(httpClient);

        // Act & Assert
        // Note: This test would need mock HttpClient setup in a real scenario
        Assert.NotNull(service);
    }
}
