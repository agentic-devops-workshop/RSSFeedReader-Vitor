namespace RSSFeedReader.API.DTOs;

public class CreateSubscriptionRequest
{
    public string Url { get; set; } = string.Empty;
}

public class SubscriptionResponse
{
    public Guid Id { get; set; }
    public string Url { get; set; } = string.Empty;
}
