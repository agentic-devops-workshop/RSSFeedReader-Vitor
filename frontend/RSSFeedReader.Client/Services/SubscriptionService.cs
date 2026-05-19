namespace RSSFeedReader.Client.Services;

using System.Net.Http.Json;

public class SubscriptionDto
{
    public Guid Id { get; set; }
    public string Url { get; set; } = string.Empty;
}

public class CreateSubscriptionRequest
{
    public string Url { get; set; } = string.Empty;
}

public class SubscriptionService
{
    private readonly HttpClient _httpClient;
    private const string ApiBaseUrl = "http://localhost:5008/api/subscriptions";

    public SubscriptionService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<SubscriptionDto> AddSubscriptionAsync(string url)
    {
        var request = new CreateSubscriptionRequest { Url = url };
        var response = await _httpClient.PostAsJsonAsync(ApiBaseUrl, request);
        
        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"Failed to add subscription: {response.StatusCode}");
        }

        var result = await response.Content.ReadFromJsonAsync<SubscriptionDto>();
        return result ?? throw new InvalidOperationException("Failed to deserialize subscription response");
    }

    public async Task<List<SubscriptionDto>> GetAllSubscriptionsAsync()
    {
        try
        {
            var subscriptions = await _httpClient.GetFromJsonAsync<List<SubscriptionDto>>(ApiBaseUrl);
            return subscriptions ?? new List<SubscriptionDto>();
        }
        catch (Exception ex)
        {
            throw new HttpRequestException($"Failed to fetch subscriptions: {ex.Message}", ex);
        }
    }
}
