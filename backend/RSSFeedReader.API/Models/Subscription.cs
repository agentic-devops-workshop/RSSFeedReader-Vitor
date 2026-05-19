namespace RSSFeedReader.API.Models;

public class Subscription
{
    public Guid Id { get; set; }
    public string Url { get; set; } = string.Empty;
}
